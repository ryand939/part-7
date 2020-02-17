namespace part_7
{
	partial class Form1
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.button1 = new System.Windows.Forms.Button();
			this.lblRemoveNum = new System.Windows.Forms.Label();
			this.btnRemoveNumber = new System.Windows.Forms.Button();
			this.btnNewList = new System.Windows.Forms.Button();
			this.btnSortNumbers = new System.Windows.Forms.Button();
			this.listNumbers = new System.Windows.Forms.ListBox();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.btnRemoveHero = new System.Windows.Forms.Button();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.btnAddHero = new System.Windows.Forms.Button();
			this.txtAddHero = new System.Windows.Forms.TextBox();
			this.btnNewHeroes = new System.Windows.Forms.Button();
			this.listHeroes = new System.Windows.Forms.ListBox();
			this.btnSortHeroes = new System.Windows.Forms.Button();
			this.lblStatus = new System.Windows.Forms.Label();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.button1);
			this.groupBox1.Controls.Add(this.lblRemoveNum);
			this.groupBox1.Controls.Add(this.btnRemoveNumber);
			this.groupBox1.Controls.Add(this.btnNewList);
			this.groupBox1.Controls.Add(this.btnSortNumbers);
			this.groupBox1.Controls.Add(this.listNumbers);
			this.groupBox1.Location = new System.Drawing.Point(7, 3);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(200, 198);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Numbers";
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(97, 172);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(97, 21);
			this.button1.TabIndex = 5;
			this.button1.Text = "Remove All";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// lblRemoveNum
			// 
			this.lblRemoveNum.AutoSize = true;
			this.lblRemoveNum.Location = new System.Drawing.Point(3, 143);
			this.lblRemoveNum.Name = "lblRemoveNum";
			this.lblRemoveNum.Size = new System.Drawing.Size(90, 26);
			this.lblRemoveNum.TabIndex = 4;
			this.lblRemoveNum.Text = "Selected number \r\nto remove: ";
			// 
			// btnRemoveNumber
			// 
			this.btnRemoveNumber.Location = new System.Drawing.Point(97, 143);
			this.btnRemoveNumber.Name = "btnRemoveNumber";
			this.btnRemoveNumber.Size = new System.Drawing.Size(97, 25);
			this.btnRemoveNumber.TabIndex = 3;
			this.btnRemoveNumber.Text = "Remove";
			this.btnRemoveNumber.UseVisualStyleBackColor = true;
			this.btnRemoveNumber.Click += new System.EventHandler(this.btnRemoveNumber_Click);
			// 
			// btnNewList
			// 
			this.btnNewList.Location = new System.Drawing.Point(6, 19);
			this.btnNewList.Name = "btnNewList";
			this.btnNewList.Size = new System.Drawing.Size(91, 23);
			this.btnNewList.TabIndex = 2;
			this.btnNewList.Text = "New List";
			this.btnNewList.UseVisualStyleBackColor = true;
			this.btnNewList.Click += new System.EventHandler(this.btnNewList_Click);
			// 
			// btnSortNumbers
			// 
			this.btnSortNumbers.Location = new System.Drawing.Point(103, 19);
			this.btnSortNumbers.Name = "btnSortNumbers";
			this.btnSortNumbers.Size = new System.Drawing.Size(91, 23);
			this.btnSortNumbers.TabIndex = 1;
			this.btnSortNumbers.Text = "Sort";
			this.btnSortNumbers.UseVisualStyleBackColor = true;
			this.btnSortNumbers.Click += new System.EventHandler(this.btnSortNumbers_Click);
			// 
			// listNumbers
			// 
			this.listNumbers.FormattingEnabled = true;
			this.listNumbers.Location = new System.Drawing.Point(6, 45);
			this.listNumbers.Name = "listNumbers";
			this.listNumbers.Size = new System.Drawing.Size(187, 95);
			this.listNumbers.TabIndex = 0;
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.btnRemoveHero);
			this.groupBox2.Controls.Add(this.textBox1);
			this.groupBox2.Controls.Add(this.btnAddHero);
			this.groupBox2.Controls.Add(this.txtAddHero);
			this.groupBox2.Controls.Add(this.btnNewHeroes);
			this.groupBox2.Controls.Add(this.listHeroes);
			this.groupBox2.Controls.Add(this.btnSortHeroes);
			this.groupBox2.Location = new System.Drawing.Point(213, 3);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(199, 198);
			this.groupBox2.TabIndex = 1;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Heroes";
			// 
			// btnRemoveHero
			// 
			this.btnRemoveHero.Location = new System.Drawing.Point(138, 169);
			this.btnRemoveHero.Name = "btnRemoveHero";
			this.btnRemoveHero.Size = new System.Drawing.Size(56, 23);
			this.btnRemoveHero.TabIndex = 8;
			this.btnRemoveHero.Text = "Remove";
			this.btnRemoveHero.UseVisualStyleBackColor = true;
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(6, 170);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(129, 20);
			this.textBox1.TabIndex = 7;
			// 
			// btnAddHero
			// 
			this.btnAddHero.Location = new System.Drawing.Point(157, 143);
			this.btnAddHero.Name = "btnAddHero";
			this.btnAddHero.Size = new System.Drawing.Size(37, 23);
			this.btnAddHero.TabIndex = 6;
			this.btnAddHero.Text = "Add";
			this.btnAddHero.UseVisualStyleBackColor = true;
			// 
			// txtAddHero
			// 
			this.txtAddHero.Location = new System.Drawing.Point(6, 144);
			this.txtAddHero.Name = "txtAddHero";
			this.txtAddHero.Size = new System.Drawing.Size(147, 20);
			this.txtAddHero.TabIndex = 5;
			// 
			// btnNewHeroes
			// 
			this.btnNewHeroes.Location = new System.Drawing.Point(5, 19);
			this.btnNewHeroes.Name = "btnNewHeroes";
			this.btnNewHeroes.Size = new System.Drawing.Size(91, 23);
			this.btnNewHeroes.TabIndex = 4;
			this.btnNewHeroes.Text = "New List";
			this.btnNewHeroes.UseVisualStyleBackColor = true;
			this.btnNewHeroes.Click += new System.EventHandler(this.btnNewHeroes_Click);
			// 
			// listHeroes
			// 
			this.listHeroes.FormattingEnabled = true;
			this.listHeroes.Location = new System.Drawing.Point(6, 45);
			this.listHeroes.Name = "listHeroes";
			this.listHeroes.Size = new System.Drawing.Size(187, 95);
			this.listHeroes.TabIndex = 1;
			// 
			// btnSortHeroes
			// 
			this.btnSortHeroes.Location = new System.Drawing.Point(103, 19);
			this.btnSortHeroes.Name = "btnSortHeroes";
			this.btnSortHeroes.Size = new System.Drawing.Size(91, 23);
			this.btnSortHeroes.TabIndex = 3;
			this.btnSortHeroes.Text = "Sort";
			this.btnSortHeroes.UseVisualStyleBackColor = true;
			this.btnSortHeroes.Click += new System.EventHandler(this.btnSortHeroes_Click);
			// 
			// lblStatus
			// 
			this.lblStatus.AutoSize = true;
			this.lblStatus.Location = new System.Drawing.Point(7, 204);
			this.lblStatus.Name = "lblStatus";
			this.lblStatus.Size = new System.Drawing.Size(43, 13);
			this.lblStatus.TabIndex = 2;
			this.lblStatus.Text = "Status: ";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(419, 222);
			this.Controls.Add(this.lblStatus);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Name = "Form1";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Label lblRemoveNum;
		private System.Windows.Forms.Button btnRemoveNumber;
		private System.Windows.Forms.Button btnNewList;
		private System.Windows.Forms.Button btnSortNumbers;
		private System.Windows.Forms.ListBox listNumbers;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.Button btnRemoveHero;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Button btnAddHero;
		private System.Windows.Forms.TextBox txtAddHero;
		private System.Windows.Forms.Button btnNewHeroes;
		private System.Windows.Forms.ListBox listHeroes;
		private System.Windows.Forms.Button btnSortHeroes;
		private System.Windows.Forms.Label lblStatus;
	}
}

