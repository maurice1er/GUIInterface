namespace GUIInterface
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
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.wfDoB = new System.Windows.Forms.DateTimePicker();
			this.label4 = new System.Windows.Forms.Label();
			this.wfPhone = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.wfLastName = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.wfFirstName = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.wfCNI = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.wfTransmission = new System.Windows.Forms.ComboBox();
			this.wfYear = new System.Windows.Forms.ComboBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.wfModel = new System.Windows.Forms.TextBox();
			this.label8 = new System.Windows.Forms.Label();
			this.wfMarque = new System.Windows.Forms.TextBox();
			this.label9 = new System.Windows.Forms.Label();
			this.wfMatricule = new System.Windows.Forms.TextBox();
			this.label10 = new System.Windows.Forms.Label();
			this.wfCancel = new System.Windows.Forms.Button();
			this.wfSubmit = new System.Windows.Forms.Button();
			this.filterByGender = new System.Windows.Forms.ComboBox();
			this.wfDataTable = new System.Windows.Forms.DataGridView();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.wfDataTable)).BeginInit();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.wfDoB);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.wfPhone);
			this.groupBox1.Controls.Add(this.label5);
			this.groupBox1.Controls.Add(this.wfLastName);
			this.groupBox1.Controls.Add(this.label6);
			this.groupBox1.Controls.Add(this.wfFirstName);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.wfCNI);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Location = new System.Drawing.Point(31, 12);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(297, 195);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Onwer";
			// 
			// wfDoB
			// 
			this.wfDoB.CustomFormat = "yyyy-MM-dd";
			this.wfDoB.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.wfDoB.Location = new System.Drawing.Point(128, 153);
			this.wfDoB.Name = "wfDoB";
			this.wfDoB.Size = new System.Drawing.Size(149, 23);
			this.wfDoB.TabIndex = 9;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(22, 155);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(31, 15);
			this.label4.TabIndex = 8;
			this.label4.Text = "DOB";
			// 
			// wfPhone
			// 
			this.wfPhone.Location = new System.Drawing.Point(128, 119);
			this.wfPhone.Name = "wfPhone";
			this.wfPhone.Size = new System.Drawing.Size(149, 23);
			this.wfPhone.TabIndex = 7;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(22, 121);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(47, 15);
			this.label5.TabIndex = 6;
			this.label5.Text = "PHONE";
			// 
			// wfLastName
			// 
			this.wfLastName.Location = new System.Drawing.Point(128, 88);
			this.wfLastName.Name = "wfLastName";
			this.wfLastName.Size = new System.Drawing.Size(149, 23);
			this.wfLastName.TabIndex = 5;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(22, 91);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(72, 15);
			this.label6.TabIndex = 4;
			this.label6.Text = "LAST_NAME";
			this.label6.Click += new System.EventHandler(this.label6_Click);
			// 
			// wfFirstName
			// 
			this.wfFirstName.Location = new System.Drawing.Point(128, 53);
			this.wfFirstName.Name = "wfFirstName";
			this.wfFirstName.Size = new System.Drawing.Size(149, 23);
			this.wfFirstName.TabIndex = 3;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(22, 56);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(74, 15);
			this.label2.TabIndex = 2;
			this.label2.Text = "FIRST_NAME";
			// 
			// wfCNI
			// 
			this.wfCNI.Location = new System.Drawing.Point(128, 22);
			this.wfCNI.Name = "wfCNI";
			this.wfCNI.Size = new System.Drawing.Size(149, 23);
			this.wfCNI.TabIndex = 1;
			this.wfCNI.Leave += new System.EventHandler(this.wfCNI_Leave);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(22, 26);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(27, 15);
			this.label1.TabIndex = 0;
			this.label1.Text = "CNI";
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.wfTransmission);
			this.groupBox2.Controls.Add(this.wfYear);
			this.groupBox2.Controls.Add(this.label3);
			this.groupBox2.Controls.Add(this.label7);
			this.groupBox2.Controls.Add(this.wfModel);
			this.groupBox2.Controls.Add(this.label8);
			this.groupBox2.Controls.Add(this.wfMarque);
			this.groupBox2.Controls.Add(this.label9);
			this.groupBox2.Controls.Add(this.wfMatricule);
			this.groupBox2.Controls.Add(this.label10);
			this.groupBox2.Location = new System.Drawing.Point(31, 213);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(297, 195);
			this.groupBox2.TabIndex = 10;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Car";
			// 
			// wfTransmission
			// 
			this.wfTransmission.FormattingEnabled = true;
			this.wfTransmission.Items.AddRange(new object[] {
            "AUTOMATIQUE",
            "MANUEL"});
			this.wfTransmission.Location = new System.Drawing.Point(128, 118);
			this.wfTransmission.Name = "wfTransmission";
			this.wfTransmission.Size = new System.Drawing.Size(149, 23);
			this.wfTransmission.TabIndex = 10;
			// 
			// wfYear
			// 
			this.wfYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.wfYear.FormattingEnabled = true;
			this.wfYear.Items.AddRange(new object[] {
            "2023",
            "2022",
            "2021",
            "2020",
            "2019",
            "2018",
            "2017",
            "2016",
            "2015",
            "2014",
            "2013",
            "2012",
            "2011",
            "2010",
            "2009",
            "2008",
            "2007",
            "2006",
            "2005",
            "2004",
            "2003",
            "2002",
            "2001",
            "2000"});
			this.wfYear.Location = new System.Drawing.Point(128, 152);
			this.wfYear.Name = "wfYear";
			this.wfYear.Size = new System.Drawing.Size(149, 23);
			this.wfYear.TabIndex = 9;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(22, 155);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(35, 15);
			this.label3.TabIndex = 8;
			this.label3.Text = "YEAR";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(22, 121);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(90, 15);
			this.label7.TabIndex = 6;
			this.label7.Text = "TRANSMISSION";
			// 
			// wfModel
			// 
			this.wfModel.Location = new System.Drawing.Point(128, 88);
			this.wfModel.Name = "wfModel";
			this.wfModel.Size = new System.Drawing.Size(149, 23);
			this.wfModel.TabIndex = 5;
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(22, 92);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(47, 15);
			this.label8.TabIndex = 4;
			this.label8.Text = "MODEL";
			// 
			// wfMarque
			// 
			this.wfMarque.Location = new System.Drawing.Point(128, 53);
			this.wfMarque.Name = "wfMarque";
			this.wfMarque.Size = new System.Drawing.Size(149, 23);
			this.wfMarque.TabIndex = 3;
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(22, 55);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(46, 15);
			this.label9.TabIndex = 2;
			this.label9.Text = "BRAND";
			// 
			// wfMatricule
			// 
			this.wfMatricule.Location = new System.Drawing.Point(128, 22);
			this.wfMatricule.Name = "wfMatricule";
			this.wfMatricule.Size = new System.Drawing.Size(149, 23);
			this.wfMatricule.TabIndex = 1;
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Location = new System.Drawing.Point(22, 26);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(69, 15);
			this.label10.TabIndex = 0;
			this.label10.Text = "MATRICULE";
			// 
			// wfCancel
			// 
			this.wfCancel.Location = new System.Drawing.Point(33, 427);
			this.wfCancel.Name = "wfCancel";
			this.wfCancel.Size = new System.Drawing.Size(75, 23);
			this.wfCancel.TabIndex = 11;
			this.wfCancel.Text = " ";
			this.wfCancel.UseVisualStyleBackColor = true;
			this.wfCancel.Click += new System.EventHandler(this.wfCancel_Click);
			// 
			// wfSubmit
			// 
			this.wfSubmit.Location = new System.Drawing.Point(253, 427);
			this.wfSubmit.Name = "wfSubmit";
			this.wfSubmit.Size = new System.Drawing.Size(75, 23);
			this.wfSubmit.TabIndex = 12;
			this.wfSubmit.Text = "Submit";
			this.wfSubmit.UseVisualStyleBackColor = true;
			this.wfSubmit.Click += new System.EventHandler(this.wfSubmit_Click);
			// 
			// filterByGender
			// 
			this.filterByGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.filterByGender.FormattingEnabled = true;
			this.filterByGender.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.filterByGender.Items.AddRange(new object[] {
            "All",
            "Male",
            "Female"});
			this.filterByGender.Location = new System.Drawing.Point(721, 239);
			this.filterByGender.Name = "filterByGender";
			this.filterByGender.Size = new System.Drawing.Size(150, 23);
			this.filterByGender.TabIndex = 14;
			this.filterByGender.SelectedValueChanged += new System.EventHandler(this.filterByGender_ValueChanged);
			// 
			// wfDataTable
			// 
			this.wfDataTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.wfDataTable.Location = new System.Drawing.Point(367, 12);
			this.wfDataTable.Name = "wfDataTable";
			this.wfDataTable.ReadOnly = true;
			this.wfDataTable.RowHeadersVisible = false;
			this.wfDataTable.RowHeadersWidth = 31;
			this.wfDataTable.RowTemplate.Height = 25;
			this.wfDataTable.Size = new System.Drawing.Size(504, 170);
			this.wfDataTable.TabIndex = 15;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(909, 468);
			this.Controls.Add(this.wfDataTable);
			this.Controls.Add(this.filterByGender);
			this.Controls.Add(this.wfSubmit);
			this.Controls.Add(this.wfCancel);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.wfDataTable)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private GroupBox groupBox1;
		private TextBox wfCNI;
		private Label label1;
		private TextBox wfFirstName;
		private Label label2;
		private Label label4;
		private TextBox wfPhone;
		private Label label5;
		private TextBox wfLastName;
		private Label label6;
		private DateTimePicker wfDoB;
		private GroupBox groupBox2;
		private Label label3;
		private Label label7;
		private TextBox wfModel;
		private Label label8;
		private TextBox wfMarque;
		private Label label9;
		private TextBox wfMatricule;
		private Label label10;
		private Button wfCancel;
		private Button wfSubmit;
		private ComboBox filterByGender;
		private DataGridView wfDataTable;
		private ComboBox wfYear;
		private ComboBox wfTransmission;
	}
}