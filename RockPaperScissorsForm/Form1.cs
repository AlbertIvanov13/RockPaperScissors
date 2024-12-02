using System.Net.Http.Headers;
using System.Runtime.InteropServices;
using static System.Net.WebRequestMethods;

namespace RockPaperScissorsForm
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		List<string> elements1 = new List<string> { "Rock", "Paper", "Scissors" };
		List<string> elements2 = new List<string> { "Rock", "Paper", "Scissors" };
		private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
		{
			tableLayoutPanel1.BackColor = Color.Blue;
		}

		private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
		{
			tableLayoutPanel2.BackColor = Color.Red;
		}

		private void tableLayoutPanel1_Paint_1(object sender, PaintEventArgs e)
		{

		}

		private void label1_Click(object sender, EventArgs e)
		{

		}

		private void label2_Click(object sender, EventArgs e)
		{

		}

		private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
		{

		}

		private void listBox1_SelectedIndexChanged_1(object sender, EventArgs e)
		{
			if (listBox1.SelectedItem == "Rock")
			{
				pictureBox1.Visible = true;
				pictureBox2.Visible = false;
				pictureBox3.Visible = false;
				pictureBox1.BackColor = Color.DodgerBlue;
			}
			else if (listBox1.SelectedItem == "Paper")
			{
				pictureBox1.Visible = false;
				pictureBox2.Visible = true;
				pictureBox3.Visible = false;
				pictureBox2.BackColor = Color.DodgerBlue;
			}
			else if (listBox1.SelectedItem == "Scissors")
			{
				pictureBox1.Visible = false;
				pictureBox2.Visible = false;
				pictureBox3.Visible = true;
				pictureBox3.BackColor = Color.DodgerBlue;
			}
		}

		private void button2_Click(object sender, EventArgs e)
		{
			bool isTrue = true;
			if (isTrue)
			{
				Random randomElement = new Random();
				int element = randomElement.Next(elements2.Count);
				string randomString = elements2[element];
				label2.Text = randomString;
				if (randomString == "Rock")
				{
					if (listBox1.SelectedItem == "Rock")
					{
						pictureBox1.Visible = true;
						pictureBox2.Visible = false;
						pictureBox3.Visible = false;
						pictureBox5.Visible = false;
						pictureBox6.Visible = false;
					}
					if (listBox1.SelectedItem == "Paper")
					{
						pictureBox1.Visible = false;
						pictureBox2.Visible = true;
						pictureBox3.Visible = false;
						pictureBox5.Visible = false;
						pictureBox6.Visible = false;
					}
					if (listBox1.SelectedItem == "Scissors")
					{
						pictureBox1.Visible = false;
						pictureBox2.Visible = false;
						pictureBox3.Visible = true;
						pictureBox5.Visible = false;
						pictureBox6.Visible = false;
					}
					pictureBox4.Visible = true;
					pictureBox4.BackColor = Color.Red;
				}
				if (randomString == "Paper")
				{
					if (listBox1.SelectedItem == "Rock")
					{
						pictureBox1.Visible = true;
						pictureBox2.Visible = false;
						pictureBox3.Visible = false;
						pictureBox4.Visible = false;
						pictureBox6.Visible = false;
					}
					if (listBox1.SelectedItem == "Paper")
					{
						pictureBox1.Visible = false;
						pictureBox2.Visible = true;
						pictureBox3.Visible = false;
						pictureBox4.Visible = false;
						pictureBox6.Visible = false;
					}
					if (listBox1.SelectedItem == "Scissors")
					{
						pictureBox1.Visible = false;
						pictureBox2.Visible = false;
						pictureBox3.Visible = true;
						pictureBox4.Visible = false;
						pictureBox6.Visible = false;
					}
					pictureBox5.Visible = true;
					pictureBox5.BackColor = Color.Red;
				}
				if (randomString == "Scissors")
				{
					if (listBox1.SelectedItem == "Rock")
					{
						pictureBox1.Visible = true;
						pictureBox2.Visible = false;
						pictureBox3.Visible = false;
						pictureBox4.Visible = false;
						pictureBox5.Visible = false;
					}
					if (listBox1.SelectedItem == "Paper")
					{
						pictureBox1.Visible = false;
						pictureBox2.Visible = true;
						pictureBox3.Visible = false;
						pictureBox4.Visible = false;
						pictureBox5.Visible = false;
					}
					if (listBox1.SelectedItem == "Scissors")
					{
						pictureBox1.Visible = false;
						pictureBox2.Visible = false;
						pictureBox3.Visible = true;
						pictureBox4.Visible = false;
						pictureBox5.Visible = false;
					}
					pictureBox6.Visible = true;
					pictureBox6.BackColor = Color.Red;
				}
				WinCheck();
				isTrue = false;
			}
		}

		private void WinCheck()
		{
			if (listBox1.SelectedItem == "Rock" && label2.Text == "Scissors")
			{
				MessageBox.Show("Player 1 win!");
			}
			else if (listBox1.SelectedItem == "Rock" && label2.Text == "Paper")
			{
				MessageBox.Show("Player 2 win!");
			}
			else if (listBox1.SelectedItem == "Rock" && label2.Text == "Rock")
			{
				MessageBox.Show("Tie!");
			}

			if (listBox1.SelectedItem == "Paper" && label2.Text == "Rock")
			{
				MessageBox.Show("Player 1 win!");
			}
			else if (listBox1.SelectedItem == "Paper" && label2.Text == "Scissors")
			{
				MessageBox.Show("Player 2 win!");
			}
			else if (listBox1.SelectedItem == "Paper" && label2.Text == "Paper")
			{
				MessageBox.Show("Tie!");
			}

			if (listBox1.SelectedItem == "Scissors" && label2.Text == "Paper")
			{
				MessageBox.Show("Player 1 win!");
			}
			else if (listBox1.SelectedItem == "Scissors" && label2.Text == "Rock")
			{
				MessageBox.Show("Player 2 win!");
			}
			else if (listBox1.SelectedItem == "Scissors" && label2.Text == "Scissors")
			{
				MessageBox.Show("Tie!");
			}
		}

		private void button1_Click(object sender, EventArgs e)
		{
			Environment.Exit(0);
		}
	}
}