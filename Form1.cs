using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace part_7
{
	public partial class Form1 : Form
	{
		//declare lists
		List<int> numbers = new List<int>();
		List<string> heroes = new List<string>();

		//declare random number generator
		Random random = new Random();

		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			for(int x = 0; x < 20; x++)
			{
				numbers.Add(random.Next(100));
			}
			listNumbers.DataSource = numbers;
			heroes.Add("Superman");
			heroes.Add("Batman");
			listHeroes.DataSource = heroes;
		}

		private void btnSortNumbers_Click(object sender, EventArgs e)
		{
			numbers.Sort();
			listNumbers.DataSource = null;
			listNumbers.DataSource = numbers;
			lblStatus.Text = "Status: Numbers have been sorted lowest to highest.";

		}

		private void btnSortHeroes_Click(object sender, EventArgs e)
		{
			heroes.Sort();
			listHeroes.DataSource = null;
			listHeroes.DataSource = heroes;
			lblStatus.Text = "Status: Heroes have been sorted alphabetically.";
		}

		private void btnNewList_Click(object sender, EventArgs e)
		{
			numbers.Clear();
			for (int x = 0; x < 20; x++)
			{
				numbers.Add(random.Next(100));
			}
			listNumbers.DataSource = null;
			listNumbers.DataSource = numbers;
			lblStatus.Text = "Status: New numbers list.";

		}

		private void btnNewHeroes_Click(object sender, EventArgs e)
		{
			heroes.Clear();
			heroes.Add("Superman");
			heroes.Add("Batman");
			listHeroes.DataSource = null;
			listHeroes.DataSource = heroes;
			lblStatus.Text = "Status: New heroes list.";
		}

		private void btnRemoveNumber_Click(object sender, EventArgs e)
		{//need to check if something in list is selected before it tries to remove it
           if(listNumbers.SelectedIndex > 0)
            {
			    lblStatus.Text = $"Status: Number {numbers[listNumbers.SelectedIndex]} removed.";
			    numbers.RemoveAt(listNumbers.SelectedIndex);
			    listNumbers.DataSource = null;
			    listNumbers.DataSource = numbers;

            }

		}

		private void button1_Click(object sender, EventArgs e)
		{
			numbers.Clear();
			listNumbers.DataSource = null;
			listNumbers.DataSource = numbers;
			lblStatus.Text = $"Status: All numbers have been removed.";
		}

        private void BtnAddHero_Click(object sender, EventArgs e)
        {
            heroes.Add(txtAddHero.Text);
            listHeroes.DataSource = null;
            listHeroes.DataSource = heroes;
        }

        private void BtnRemoveHero_Click(object sender, EventArgs e)
        {
            heroes.Remove(txtRemoveHero.Text);
            listHeroes.DataSource = null;
            listHeroes.DataSource = heroes;

        }

        private void ListNumbers_SelectedValueChanged(object sender, EventArgs e)
        {
            lblRemoveNum.Text = $"Selected number \r\nto remove: {listNumbers.SelectedItem}";
        }
    }
}
