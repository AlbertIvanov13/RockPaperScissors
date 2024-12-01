namespace RockPaperScissorsForm
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		List<string> elements1 = new List<string> { "rock", "paper", "scissors" };
		List<string> elements2 = new List<string> { "rock", "paper", "scissors" };
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

		private void button1_Click(object sender, EventArgs e)
		{
			Random randomElement = new Random();
			int element = randomElement.Next(elements1.Count);
			string randomString = elements1[element];
			label1.Text = randomString;
		}

		private void button2_Click(object sender, EventArgs e)
		{
			Random randomElement = new Random();
			int element = randomElement.Next(elements2.Count);
			string randomString = elements2[element];
			label2.Text = randomString;
		}
	}
}