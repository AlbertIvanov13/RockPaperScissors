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
				label1.Text = "Rock";
			}
			else if (listBox1.SelectedItem == "Paper")
			{
				label1.Text = "Paper";
			}
			else if (listBox1.SelectedItem == "Scissors")
			{
				label1.Text = "Scissors";
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
				WinCheck();
				isTrue = false;
			}
		}

		private void WinCheck()
		{
			if (label1.Text == "Rock" && label2.Text == "Scissors")
			{
				MessageBox.Show("Player 1 win!");
			}
			else if (label1.Text == "Rock" && label2.Text == "Paper")
			{
				MessageBox.Show("Player 2 win!");
			}
			else if (label1.Text == "Rock" && label2.Text == "Rock")
			{
				MessageBox.Show("Tie!");
			}

			if (label1.Text == "Paper" && label2.Text == "Rock")
			{
				MessageBox.Show("Player 1 win!");
			}
			else if (label1.Text == "Paper" && label2.Text == "Scissors")
			{
				MessageBox.Show("Player 2 win!");
			}
			else if (label1.Text == "Paper" && label2.Text == "Paper")
			{
				MessageBox.Show("Tie!");
			}

			if (label1.Text == "Scissors" && label2.Text == "Paper")
			{
				MessageBox.Show("Player 1 win!");
			}
			else if (label1.Text == "Scissors" && label2.Text == "Rock")
			{
				MessageBox.Show("Player 2 win!");
			}
			else if (label1.Text == "Scissors" && label2.Text == "Scissors")
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