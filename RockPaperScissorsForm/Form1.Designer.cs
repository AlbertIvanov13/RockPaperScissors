namespace RockPaperScissorsForm
{
	partial class Form1
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
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
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			tableLayoutPanel1 = new TableLayoutPanel();
			label1 = new Label();
			label2 = new Label();
			tableLayoutPanel2 = new TableLayoutPanel();
			button2 = new Button();
			listBox1 = new ListBox();
			button1 = new Button();
			imageList1 = new ImageList(components);
			pictureBox1 = new PictureBox();
			pictureBox2 = new PictureBox();
			pictureBox3 = new PictureBox();
			pictureBox4 = new PictureBox();
			pictureBox5 = new PictureBox();
			pictureBox6 = new PictureBox();
			tableLayoutPanel1.SuspendLayout();
			tableLayoutPanel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
			((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
			((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
			((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
			((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
			((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
			SuspendLayout();
			// 
			// tableLayoutPanel1
			// 
			tableLayoutPanel1.Anchor = AnchorStyles.Left;
			tableLayoutPanel1.BackColor = Color.DodgerBlue;
			tableLayoutPanel1.ColumnCount = 1;
			tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 27F));
			tableLayoutPanel1.Controls.Add(label1, 0, 0);
			tableLayoutPanel1.Location = new Point(0, 0);
			tableLayoutPanel1.Name = "tableLayoutPanel1";
			tableLayoutPanel1.RowCount = 1;
			tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 28F));
			tableLayoutPanel1.Size = new Size(402, 226);
			tableLayoutPanel1.TabIndex = 0;
			tableLayoutPanel1.Paint += tableLayoutPanel1_Paint_1;
			// 
			// label1
			// 
			label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
			label1.Font = new Font("Segoe UI", 30F);
			label1.Location = new Point(101, 0);
			label1.Name = "label1";
			label1.Size = new Size(200, 226);
			label1.TabIndex = 0;
			label1.Text = "?";
			label1.TextAlign = ContentAlignment.MiddleCenter;
			label1.Click += label1_Click;
			// 
			// label2
			// 
			label2.Anchor = AnchorStyles.None;
			label2.Font = new Font("Segoe UI", 30F);
			label2.Location = new Point(51, 0);
			label2.Name = "label2";
			label2.Size = new Size(300, 225);
			label2.TabIndex = 0;
			label2.Text = "?";
			label2.TextAlign = ContentAlignment.MiddleCenter;
			label2.Click += label2_Click;
			// 
			// tableLayoutPanel2
			// 
			tableLayoutPanel2.Anchor = AnchorStyles.None;
			tableLayoutPanel2.BackColor = Color.Red;
			tableLayoutPanel2.ColumnCount = 1;
			tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
			tableLayoutPanel2.Controls.Add(label2, 0, 0);
			tableLayoutPanel2.Location = new Point(0, 228);
			tableLayoutPanel2.Name = "tableLayoutPanel2";
			tableLayoutPanel2.RowCount = 1;
			tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
			tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
			tableLayoutPanel2.Size = new Size(402, 226);
			tableLayoutPanel2.TabIndex = 1;
			// 
			// button2
			// 
			button2.Location = new Point(512, 316);
			button2.Name = "button2";
			button2.Size = new Size(94, 29);
			button2.TabIndex = 3;
			button2.Text = "button2";
			button2.UseVisualStyleBackColor = true;
			button2.Click += button2_Click;
			// 
			// listBox1
			// 
			listBox1.FormattingEnabled = true;
			listBox1.Items.AddRange(new object[] { "Rock", "Paper", "Scissors" });
			listBox1.Location = new Point(480, 54);
			listBox1.Name = "listBox1";
			listBox1.Size = new Size(150, 104);
			listBox1.TabIndex = 4;
			listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged_1;
			// 
			// button1
			// 
			button1.Location = new Point(485, 202);
			button1.Name = "button1";
			button1.Size = new Size(145, 64);
			button1.TabIndex = 5;
			button1.Text = "End of the game?";
			button1.UseVisualStyleBackColor = true;
			button1.Click += button1_Click;
			// 
			// imageList1
			// 
			imageList1.ColorDepth = ColorDepth.Depth32Bit;
			imageList1.ImageSize = new Size(16, 16);
			imageList1.TransparentColor = Color.Transparent;
			// 
			// pictureBox1
			// 
			pictureBox1.BackColor = Color.Transparent;
			pictureBox1.BackgroundImageLayout = ImageLayout.None;
			pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
			pictureBox1.InitialImage = (Image)resources.GetObject("pictureBox1.InitialImage");
			pictureBox1.Location = new Point(86, 0);
			pictureBox1.Name = "pictureBox1";
			pictureBox1.Size = new Size(215, 226);
			pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
			pictureBox1.TabIndex = 6;
			pictureBox1.TabStop = false;
			pictureBox1.Visible = false;
			// 
			// pictureBox2
			// 
			pictureBox2.BackColor = Color.Transparent;
			pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
			pictureBox2.Location = new Point(86, 0);
			pictureBox2.Name = "pictureBox2";
			pictureBox2.Size = new Size(215, 225);
			pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
			pictureBox2.TabIndex = 7;
			pictureBox2.TabStop = false;
			pictureBox2.Visible = false;
			// 
			// pictureBox3
			// 
			pictureBox3.BackColor = Color.Transparent;
			pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
			pictureBox3.Location = new Point(86, 0);
			pictureBox3.Name = "pictureBox3";
			pictureBox3.Size = new Size(215, 222);
			pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
			pictureBox3.TabIndex = 8;
			pictureBox3.TabStop = false;
			pictureBox3.Visible = false;
			// 
			// pictureBox4
			// 
			pictureBox4.BackColor = Color.Transparent;
			pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
			pictureBox4.Location = new Point(86, 228);
			pictureBox4.Margin = new Padding(3, 0, 3, 0);
			pictureBox4.Name = "pictureBox4";
			pictureBox4.Size = new Size(215, 225);
			pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
			pictureBox4.TabIndex = 9;
			pictureBox4.TabStop = false;
			pictureBox4.Visible = false;
			// 
			// pictureBox5
			// 
			pictureBox5.BackColor = Color.Transparent;
			pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
			pictureBox5.Location = new Point(86, 228);
			pictureBox5.Name = "pictureBox5";
			pictureBox5.Size = new Size(215, 225);
			pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
			pictureBox5.TabIndex = 10;
			pictureBox5.TabStop = false;
			pictureBox5.Visible = false;
			// 
			// pictureBox6
			// 
			pictureBox6.BackColor = Color.Transparent;
			pictureBox6.Image = (Image)resources.GetObject("pictureBox6.Image");
			pictureBox6.Location = new Point(86, 228);
			pictureBox6.Name = "pictureBox6";
			pictureBox6.Size = new Size(215, 225);
			pictureBox6.SizeMode = PictureBoxSizeMode.StretchImage;
			pictureBox6.TabIndex = 11;
			pictureBox6.TabStop = false;
			pictureBox6.Visible = false;
			// 
			// Form1
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(689, 450);
			Controls.Add(pictureBox6);
			Controls.Add(pictureBox5);
			Controls.Add(pictureBox4);
			Controls.Add(pictureBox3);
			Controls.Add(pictureBox2);
			Controls.Add(pictureBox1);
			Controls.Add(button1);
			Controls.Add(listBox1);
			Controls.Add(button2);
			Controls.Add(tableLayoutPanel2);
			Controls.Add(tableLayoutPanel1);
			Name = "Form1";
			Text = "Form1";
			tableLayoutPanel1.ResumeLayout(false);
			tableLayoutPanel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
			((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
			((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
			((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
			((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
			((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
			ResumeLayout(false);
		}

		#endregion

		private TableLayoutPanel tableLayoutPanel1;
		private Label label1;
		private Label label2;
		private TableLayoutPanel tableLayoutPanel2;
		private Button button2;
		private ListBox listBox1;
		private Button button1;
		private ImageList imageList1;
		private PictureBox pictureBox1;
		private PictureBox pictureBox2;
		private PictureBox pictureBox3;
		private PictureBox pictureBox4;
		private PictureBox pictureBox5;
		private PictureBox pictureBox6;
	}
}
