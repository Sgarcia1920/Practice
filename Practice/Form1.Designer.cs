namespace Practice
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
			label1 = new Label();
			txtName = new TextBox();
			TxtPaternalSurname = new TextBox();
			label2 = new Label();
			txtMorherSurname = new TextBox();
			label3 = new Label();
			label4 = new Label();
			Dtdatebirth = new DateTimePicker();
			label5 = new Label();
			txtidnumber = new TextBox();
			xd = new Label();
			txtcareer = new TextBox();
			label6 = new Label();
			btncreate = new Button();
			lbstudentinformation = new Label();
			Numupdown_average = new NumericUpDown();
			((System.ComponentModel.ISupportInitialize)Numupdown_average).BeginInit();
			SuspendLayout();
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Sitka Display", 14.2499981F, FontStyle.Bold);
			label1.Location = new Point(12, 27);
			label1.Name = "label1";
			label1.Size = new Size(59, 28);
			label1.TabIndex = 0;
			label1.Text = "Name";
			// 
			// txtName
			// 
			txtName.Location = new Point(12, 58);
			txtName.Name = "txtName";
			txtName.Size = new Size(177, 23);
			txtName.TabIndex = 1;
			// 
			// TxtPaternalSurname
			// 
			TxtPaternalSurname.Location = new Point(195, 58);
			TxtPaternalSurname.Name = "TxtPaternalSurname";
			TxtPaternalSurname.Size = new Size(191, 23);
			TxtPaternalSurname.TabIndex = 3;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Font = new Font("Sitka Display", 14.2499981F, FontStyle.Bold);
			label2.Location = new Point(200, 27);
			label2.Name = "label2";
			label2.Size = new Size(158, 28);
			label2.TabIndex = 2;
			label2.Text = "Paternal Surname";
			// 
			// txtMorherSurname
			// 
			txtMorherSurname.Location = new Point(392, 58);
			txtMorherSurname.Name = "txtMorherSurname";
			txtMorherSurname.Size = new Size(195, 23);
			txtMorherSurname.TabIndex = 5;
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Font = new Font("Sitka Display", 14.2499981F, FontStyle.Bold);
			label3.ForeColor = Color.Black;
			label3.Location = new Point(392, 27);
			label3.Name = "label3";
			label3.Size = new Size(150, 28);
			label3.TabIndex = 4;
			label3.Text = "Mother Surname";
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Font = new Font("Sitka Display", 14.2499981F, FontStyle.Bold);
			label4.Location = new Point(12, 115);
			label4.Name = "label4";
			label4.Size = new Size(116, 28);
			label4.TabIndex = 6;
			label4.Text = "Date of Birth";
			// 
			// Dtdatebirth
			// 
			Dtdatebirth.Format = DateTimePickerFormat.Short;
			Dtdatebirth.Location = new Point(12, 146);
			Dtdatebirth.Name = "Dtdatebirth";
			Dtdatebirth.Size = new Size(177, 23);
			Dtdatebirth.TabIndex = 7;
			Dtdatebirth.Value = new DateTime(2024, 3, 7, 0, 0, 0, 0);
			// 
			// label5
			// 
			label5.AutoSize = true;
			label5.Font = new Font("Sitka Display", 14.2499981F, FontStyle.Bold);
			label5.Location = new Point(193, 115);
			label5.Name = "label5";
			label5.Size = new Size(193, 28);
			label5.TabIndex = 8;
			label5.Text = "Identification Number";
			// 
			// txtidnumber
			// 
			txtidnumber.Location = new Point(195, 146);
			txtidnumber.Name = "txtidnumber";
			txtidnumber.Size = new Size(186, 23);
			txtidnumber.TabIndex = 9;
			// 
			// xd
			// 
			xd.AutoSize = true;
			xd.Font = new Font("Sitka Display", 14.2499981F, FontStyle.Bold);
			xd.Location = new Point(399, 115);
			xd.Name = "xd";
			xd.Size = new Size(66, 28);
			xd.TabIndex = 10;
			xd.Text = "Career";
			// 
			// txtcareer
			// 
			txtcareer.Location = new Point(395, 146);
			txtcareer.Name = "txtcareer";
			txtcareer.Size = new Size(192, 23);
			txtcareer.TabIndex = 11;
			// 
			// label6
			// 
			label6.AutoSize = true;
			label6.Font = new Font("Sitka Display", 14.2499981F, FontStyle.Bold);
			label6.Location = new Point(12, 206);
			label6.Name = "label6";
			label6.Size = new Size(76, 28);
			label6.TabIndex = 12;
			label6.Text = "Average";
			// 
			// btncreate
			// 
			btncreate.BackColor = Color.OliveDrab;
			btncreate.Font = new Font("Nirmala UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
			btncreate.ForeColor = Color.White;
			btncreate.Location = new Point(245, 328);
			btncreate.Name = "btncreate";
			btncreate.Size = new Size(136, 48);
			btncreate.TabIndex = 14;
			btncreate.Text = "Create";
			btncreate.UseVisualStyleBackColor = false;
			btncreate.Click += btncreate_Click;
			// 
			// lbstudentinformation
			// 
			lbstudentinformation.AutoSize = true;
			lbstudentinformation.BackColor = Color.Silver;
			lbstudentinformation.Font = new Font("MS Reference Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
			lbstudentinformation.ForeColor = SystemColors.ActiveCaptionText;
			lbstudentinformation.Location = new Point(234, 188);
			lbstudentinformation.Name = "lbstudentinformation";
			lbstudentinformation.Size = new Size(0, 19);
			lbstudentinformation.TabIndex = 15;
			// 
			// Numupdown_average
			// 
			Numupdown_average.Location = new Point(12, 237);
			Numupdown_average.Name = "Numupdown_average";
			Numupdown_average.Size = new Size(177, 23);
			Numupdown_average.TabIndex = 16;
			// 
			// Form1
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.LightGray;
			ClientSize = new Size(611, 405);
			Controls.Add(Numupdown_average);
			Controls.Add(lbstudentinformation);
			Controls.Add(btncreate);
			Controls.Add(label6);
			Controls.Add(txtcareer);
			Controls.Add(xd);
			Controls.Add(txtidnumber);
			Controls.Add(label5);
			Controls.Add(Dtdatebirth);
			Controls.Add(label4);
			Controls.Add(txtMorherSurname);
			Controls.Add(label3);
			Controls.Add(TxtPaternalSurname);
			Controls.Add(label2);
			Controls.Add(txtName);
			Controls.Add(label1);
			Name = "Form1";
			Text = "REGISTRATION";
			((System.ComponentModel.ISupportInitialize)Numupdown_average).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label label1;
		private TextBox txtName;
		private TextBox TxtPaternalSurname;
		private Label label2;
		private TextBox txtMorherSurname;
		private Label label3;
		private Label label4;
		private DateTimePicker Dtdatebirth;
		private Label label5;
		private TextBox txtidnumber;
		private Label xd;
		private TextBox txtcareer;
		private Label label6;
		private Button btncreate;
		private Label lbstudentinformation;
		private NumericUpDown Numupdown_average;
	}
}
