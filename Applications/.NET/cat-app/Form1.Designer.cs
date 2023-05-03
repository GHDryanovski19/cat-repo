namespace cat_app
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
			minimizeBtn = new Button();
			xBtn = new Button();
			pictureBox1 = new PictureBox();
			refreshImageBtn = new Button();
			((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
			SuspendLayout();
			// 
			// minimizeBtn
			// 
			minimizeBtn.BackColor = Color.Transparent;
			minimizeBtn.FlatAppearance.BorderSize = 0;
			minimizeBtn.FlatStyle = FlatStyle.Flat;
			minimizeBtn.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
			minimizeBtn.ForeColor = Color.FromArgb(20, 20, 22);
			minimizeBtn.Location = new Point(523, 1);
			minimizeBtn.Name = "minimizeBtn";
			minimizeBtn.Size = new Size(35, 35);
			minimizeBtn.TabIndex = 3;
			minimizeBtn.Text = "—";
			minimizeBtn.UseVisualStyleBackColor = false;
			minimizeBtn.Click += minimizeBtn_Click;
			// 
			// xBtn
			// 
			xBtn.BackColor = Color.Transparent;
			xBtn.FlatAppearance.BorderSize = 0;
			xBtn.FlatStyle = FlatStyle.Flat;
			xBtn.Font = new Font("Impact", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
			xBtn.ForeColor = Color.FromArgb(20, 20, 22);
			xBtn.Location = new Point(564, 1);
			xBtn.Name = "xBtn";
			xBtn.Size = new Size(35, 35);
			xBtn.TabIndex = 2;
			xBtn.Text = "✖";
			xBtn.UseVisualStyleBackColor = false;
			xBtn.Click += xBtn_Click;
			// 
			// pictureBox1
			// 
			pictureBox1.Location = new Point(48, 92);
			pictureBox1.Name = "pictureBox1";
			pictureBox1.Size = new Size(500, 500);
			pictureBox1.TabIndex = 4;
			pictureBox1.TabStop = false;
			// 
			// refreshImageBtn
			// 
			refreshImageBtn.BackColor = Color.Violet;
			refreshImageBtn.FlatAppearance.BorderSize = 0;
			refreshImageBtn.FlatStyle = FlatStyle.Flat;
			refreshImageBtn.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
			refreshImageBtn.ForeColor = Color.White;
			refreshImageBtn.Location = new Point(48, 32);
			refreshImageBtn.Name = "refreshImageBtn";
			refreshImageBtn.Size = new Size(178, 42);
			refreshImageBtn.TabIndex = 5;
			refreshImageBtn.Text = "REFRESH CAT";
			refreshImageBtn.UseVisualStyleBackColor = false;
			refreshImageBtn.Click += refreshImageBtn_Click;
			// 
			// Form1
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.FromArgb(218, 218, 230);
			ClientSize = new Size(600, 650);
			Controls.Add(refreshImageBtn);
			Controls.Add(pictureBox1);
			Controls.Add(minimizeBtn);
			Controls.Add(xBtn);
			FormBorderStyle = FormBorderStyle.None;
			Name = "Form1";
			Text = "cat app";
			MouseDown += Form1_MouseDown;
			MouseMove += Form1_MouseMove;
			MouseUp += Form1_MouseUp;
			((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
			ResumeLayout(false);
		}

		#endregion

		private Button minimizeBtn;
		private Button xBtn;
		private PictureBox pictureBox1;
		private Button refreshImageBtn;
	}
}