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
			if(listNumbers.Items.Count > 0)
			{
			numbers.Sort();
			listNumbers.DataSource = null;
			listNumbers.DataSource = numbers;
			lblStatus.Text = "Status: Numbers have been sorted lowest to highest.";
			}
			else
			{
				lblStatus.Text = "Status: There are no numbers to sort.";
			}


		}

		private void btnSortHeroes_Click(object sender, EventArgs e)
		{
			if(listHeroes.Items.Count > 0)
			{

			heroes.Sort();
			listHeroes.DataSource = null;
			listHeroes.DataSource = heroes;
			lblStatus.Text = "Status: Heroes have been sorted alphabetically.";
			}
			else
			{
				lblStatus.Text = "Status: There are no heroes to sort.";
			}
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
			btnRemoveNumber.Enabled = true;
			btnRemoveNumber.Enabled = true;
			button1.Enabled = true;

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
           if(listNumbers.SelectedIndex >= 0)
            {
			    lblStatus.Text = $"Status: Number {numbers[listNumbers.SelectedIndex]} removed.";
			    numbers.RemoveAt(listNumbers.SelectedIndex);
			    listNumbers.DataSource = null;
			    listNumbers.DataSource = numbers;
            }
		   if(listNumbers.Items.Count == 0)
			{
				btnRemoveNumber.Enabled = false;
				button1.Enabled = false;
			}
			else 
			{

				btnRemoveNumber.Enabled = true;
				button1.Enabled = true;
			}

		}

		private void button1_Click(object sender, EventArgs e)
		{
			numbers.Clear();
			listNumbers.DataSource = null;
			listNumbers.DataSource = numbers;
			lblStatus.Text = $"Status: All numbers have been removed.";
			btnRemoveNumber.Enabled = false;

			if (listNumbers.Items.Count == 0)
			{
				btnRemoveNumber.Enabled = false;
				button1.Enabled = false;
			}
			else
			{

				btnRemoveNumber.Enabled = true;
				button1.Enabled = true;
			}
		}

        private void BtnAddHero_Click(object sender, EventArgs e)
        {
            string userEntry = txtAddHero.Text;
			if(txtAddHero.Text != "")
			{
				heroes.Add(txtAddHero.Text);
				heroes = heroes.Distinct().ToList();
				listHeroes.DataSource = null;
				listHeroes.DataSource = heroes;
                lblStatus.Text = $"Status: The hero \"{userEntry}\" has been added.";
			}


			txtAddHero.Text = "";
		}



        private void BtnRemoveHero_Click(object sender, EventArgs e)
        {
			string userEntry = txtRemoveHero.Text;
			List<string> heroesLower = heroes.ConvertAll(d => d.ToLower()).ToList();
			if (heroesLower.Contains(txtRemoveHero.Text.ToLower()))
			{

				int indexOfHero = heroesLower.IndexOf(txtRemoveHero.Text.ToLower());
				heroesLower.RemoveAt(indexOfHero);
				heroes.RemoveAt(indexOfHero);
				listHeroes.DataSource = null;
				listHeroes.DataSource = heroes;
                lblStatus.Text = $"Status: The hero \"{userEntry}\" has been removed.";
            }
			else
			{
				lblStatus.Text = $"Status: The hero \"{userEntry}\" does not exist in the list.";
			}
            txtRemoveHero.Text = "";
        }



        private void ListNumbers_SelectedValueChanged(object sender, EventArgs e)
        {
			if (listNumbers.SelectedItem == null)
			{

				lblRemoveNum.Text = "No selection \r\nhas been made.";
				btnRemoveNumber.Enabled = false;

			}
			else
			{
				btnRemoveNumber.Enabled = true;
				lblRemoveNum.Text = $"Selected number \r\nto remove: {listNumbers.SelectedItem}";
			}
        }

		private void listNumbers_SelectedIndexChanged(object sender, EventArgs e)
		{

		}

		private void txtRemoveHero_TextChanged(object sender, EventArgs e)
		{

		}
	}
}
