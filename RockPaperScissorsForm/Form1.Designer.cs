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
			tableLayoutPanel1 = new TableLayoutPanel();
			label1 = new Label();
			label2 = new Label();
			tableLayoutPanel2 = new TableLayoutPanel();
			button2 = new Button();
			listBox1 = new ListBox();
			tableLayoutPanel1.SuspendLayout();
			tableLayoutPanel2.SuspendLayout();
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
			// Form1
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(689, 450);
			Controls.Add(listBox1);
			Controls.Add(button2);
			Controls.Add(tableLayoutPanel2);
			Controls.Add(tableLayoutPanel1);
			Name = "Form1";
			Text = "Form1";
			tableLayoutPanel1.ResumeLayout(false);
			tableLayoutPanel2.ResumeLayout(false);
			ResumeLayout(false);
		}

		#endregion

		private TableLayoutPanel tableLayoutPanel1;
		private Label label1;
		private Label label2;
		private TableLayoutPanel tableLayoutPanel2;
		private Button button2;
		private ListBox listBox1;
	}
}
