﻿namespace SchoolManagementSystem
{
    partial class AddMarks
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddMarks));
            this.lbRegNo = new System.Windows.Forms.Label();
            this.lbSubName = new System.Windows.Forms.Label();
            this.lbExam = new System.Windows.Forms.Label();
            this.lbMarks = new System.Windows.Forms.Label();
            this.lbYear = new System.Windows.Forms.Label();
            this.tbRegNo = new System.Windows.Forms.TextBox();
            this.tbMarks = new System.Windows.Forms.TextBox();
            this.tbSubName = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.cmbExam = new System.Windows.Forms.ComboBox();
            this.btnInsert = new System.Windows.Forms.Button();
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.lbSearch = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAddTimetableA = new System.Windows.Forms.Button();
            this.btnManageTimetableA = new System.Windows.Forms.Button();
            this.btnManageMarksA = new System.Windows.Forms.Button();
            this.btnTeachersHomeA = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnUpdateDeleteMarksA = new System.Windows.Forms.Button();
            this.btnStudentResultsheetA = new System.Windows.Forms.Button();
            this.btnClassResultSheetA = new System.Windows.Forms.Button();
            this.btnSectionResultSheetA = new System.Windows.Forms.Button();
            this.btnUpdateDeleteTimetableA = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbRegNo
            // 
            this.lbRegNo.AutoSize = true;
            this.lbRegNo.Location = new System.Drawing.Point(19, 42);
            this.lbRegNo.Name = "lbRegNo";
            this.lbRegNo.Size = new System.Drawing.Size(138, 17);
            this.lbRegNo.TabIndex = 0;
            this.lbRegNo.Text = "Registration Number";
            this.lbRegNo.Click += new System.EventHandler(this.Label1_Click);
            // 
            // lbSubName
            // 
            this.lbSubName.AutoSize = true;
            this.lbSubName.Location = new System.Drawing.Point(19, 93);
            this.lbSubName.Name = "lbSubName";
            this.lbSubName.Size = new System.Drawing.Size(96, 17);
            this.lbSubName.TabIndex = 1;
            this.lbSubName.Text = "Subject Name";
            // 
            // lbExam
            // 
            this.lbExam.AutoSize = true;
            this.lbExam.Location = new System.Drawing.Point(19, 151);
            this.lbExam.Name = "lbExam";
            this.lbExam.Size = new System.Drawing.Size(84, 17);
            this.lbExam.TabIndex = 2;
            this.lbExam.Text = "Select exam";
            this.lbExam.Click += new System.EventHandler(this.LbExam_Click);
            // 
            // lbMarks
            // 
            this.lbMarks.AutoSize = true;
            this.lbMarks.Location = new System.Drawing.Point(19, 210);
            this.lbMarks.Name = "lbMarks";
            this.lbMarks.Size = new System.Drawing.Size(84, 17);
            this.lbMarks.TabIndex = 3;
            this.lbMarks.Text = "Enter Marks";
            this.lbMarks.Click += new System.EventHandler(this.LbMarks_Click);
            // 
            // lbYear
            // 
            this.lbYear.AutoSize = true;
            this.lbYear.Location = new System.Drawing.Point(19, 262);
            this.lbYear.Name = "lbYear";
            this.lbYear.Size = new System.Drawing.Size(76, 17);
            this.lbYear.TabIndex = 4;
            this.lbYear.Text = "Enter Year";
            // 
            // tbRegNo
            // 
            this.tbRegNo.Location = new System.Drawing.Point(172, 37);
            this.tbRegNo.Name = "tbRegNo";
            this.tbRegNo.Size = new System.Drawing.Size(200, 22);
            this.tbRegNo.TabIndex = 5;
            // 
            // tbMarks
            // 
            this.tbMarks.Location = new System.Drawing.Point(172, 205);
            this.tbMarks.Name = "tbMarks";
            this.tbMarks.Size = new System.Drawing.Size(200, 22);
            this.tbMarks.TabIndex = 6;
            // 
            // tbSubName
            // 
            this.tbSubName.Location = new System.Drawing.Point(172, 90);
            this.tbSubName.Name = "tbSubName";
            this.tbSubName.Size = new System.Drawing.Size(200, 22);
            this.tbSubName.TabIndex = 7;
            this.tbSubName.TextChanged += new System.EventHandler(this.TbSubName_TextChanged);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(172, 257);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker1.TabIndex = 8;
            // 
            // cmbExam
            // 
            this.cmbExam.FormattingEnabled = true;
            this.cmbExam.Location = new System.Drawing.Point(172, 148);
            this.cmbExam.Name = "cmbExam";
            this.cmbExam.Size = new System.Drawing.Size(200, 24);
            this.cmbExam.TabIndex = 9;
            // 
            // btnInsert
            // 
            this.btnInsert.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnInsert.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsert.Location = new System.Drawing.Point(113, 398);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(130, 50);
            this.btnInsert.TabIndex = 11;
            this.btnInsert.Text = "Insert";
            this.btnInsert.UseVisualStyleBackColor = false;
            this.btnInsert.Click += new System.EventHandler(this.Button1_Click);
            // 
            // tbSearch
            // 
            this.tbSearch.Location = new System.Drawing.Point(91, 18);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(403, 22);
            this.tbSearch.TabIndex = 12;
            // 
            // lbSearch
            // 
            this.lbSearch.AutoSize = true;
            this.lbSearch.Location = new System.Drawing.Point(23, 18);
            this.lbSearch.Name = "lbSearch";
            this.lbSearch.Size = new System.Drawing.Size(53, 17);
            this.lbSearch.TabIndex = 13;
            this.lbSearch.Text = "Search";
            this.lbSearch.Click += new System.EventHandler(this.Label1_Click_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pictureBox1.Location = new System.Drawing.Point(12, 108);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(260, 220);
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.PictureBox1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.btnUpdateDeleteTimetableA);
            this.panel1.Controls.Add(this.btnSectionResultSheetA);
            this.panel1.Controls.Add(this.btnClassResultSheetA);
            this.panel1.Controls.Add(this.btnStudentResultsheetA);
            this.panel1.Controls.Add(this.btnUpdateDeleteMarksA);
            this.panel1.Controls.Add(this.btnAddTimetableA);
            this.panel1.Controls.Add(this.btnManageTimetableA);
            this.panel1.Controls.Add(this.btnManageMarksA);
            this.panel1.Controls.Add(this.btnTeachersHomeA);
            this.panel1.Location = new System.Drawing.Point(12, 334);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(260, 335);
            this.panel1.TabIndex = 15;
            // 
            // btnAddTimetableA
            // 
            this.btnAddTimetableA.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnAddTimetableA.Location = new System.Drawing.Point(11, 256);
            this.btnAddTimetableA.Name = "btnAddTimetableA";
            this.btnAddTimetableA.Size = new System.Drawing.Size(235, 35);
            this.btnAddTimetableA.TabIndex = 21;
            this.btnAddTimetableA.Text = "Add Timetable";
            this.btnAddTimetableA.UseVisualStyleBackColor = false;
            // 
            // btnManageTimetableA
            // 
            this.btnManageTimetableA.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnManageTimetableA.Location = new System.Drawing.Point(11, 220);
            this.btnManageTimetableA.Name = "btnManageTimetableA";
            this.btnManageTimetableA.Size = new System.Drawing.Size(235, 35);
            this.btnManageTimetableA.TabIndex = 22;
            this.btnManageTimetableA.Text = "Get Timetable";
            this.btnManageTimetableA.UseVisualStyleBackColor = false;
            this.btnManageTimetableA.Click += new System.EventHandler(this.BtnManageTimetableA_Click);
            // 
            // btnManageMarksA
            // 
            this.btnManageMarksA.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnManageMarksA.Location = new System.Drawing.Point(11, 40);
            this.btnManageMarksA.Name = "btnManageMarksA";
            this.btnManageMarksA.Size = new System.Drawing.Size(235, 35);
            this.btnManageMarksA.TabIndex = 17;
            this.btnManageMarksA.Text = "Manage Marks";
            this.btnManageMarksA.UseVisualStyleBackColor = false;
            this.btnManageMarksA.Click += new System.EventHandler(this.BtnManageMarksA_Click);
            // 
            // btnTeachersHomeA
            // 
            this.btnTeachersHomeA.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnTeachersHomeA.Location = new System.Drawing.Point(11, 3);
            this.btnTeachersHomeA.Name = "btnTeachersHomeA";
            this.btnTeachersHomeA.Size = new System.Drawing.Size(235, 35);
            this.btnTeachersHomeA.TabIndex = 17;
            this.btnTeachersHomeA.Text = "Teachers Home";
            this.btnTeachersHomeA.UseVisualStyleBackColor = false;
            this.btnTeachersHomeA.Click += new System.EventHandler(this.BtnTeachersHomeA_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(36, 134);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(210, 180);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 16;
            this.pictureBox2.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Controls.Add(this.tbRegNo);
            this.panel2.Controls.Add(this.lbRegNo);
            this.panel2.Controls.Add(this.lbSubName);
            this.panel2.Controls.Add(this.lbExam);
            this.panel2.Controls.Add(this.lbMarks);
            this.panel2.Controls.Add(this.lbYear);
            this.panel2.Controls.Add(this.btnInsert);
            this.panel2.Controls.Add(this.tbMarks);
            this.panel2.Controls.Add(this.cmbExam);
            this.panel2.Controls.Add(this.tbSubName);
            this.panel2.Controls.Add(this.dateTimePicker1);
            this.panel2.Location = new System.Drawing.Point(296, 156);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(389, 487);
            this.panel2.TabIndex = 17;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel2_Paint);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel3.Controls.Add(this.dataGridView1);
            this.panel3.Controls.Add(this.tbSearch);
            this.panel3.Controls.Add(this.lbSearch);
            this.panel3.Location = new System.Drawing.Point(703, 156);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(547, 487);
            this.panel3.TabIndex = 18;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(19, 64);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(508, 405);
            this.dataGridView1.TabIndex = 14;
            // 
            // btnUpdateDeleteMarksA
            // 
            this.btnUpdateDeleteMarksA.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnUpdateDeleteMarksA.Location = new System.Drawing.Point(11, 76);
            this.btnUpdateDeleteMarksA.Name = "btnUpdateDeleteMarksA";
            this.btnUpdateDeleteMarksA.Size = new System.Drawing.Size(235, 35);
            this.btnUpdateDeleteMarksA.TabIndex = 19;
            this.btnUpdateDeleteMarksA.Text = "Update Marks / Delete Marks";
            this.btnUpdateDeleteMarksA.UseVisualStyleBackColor = false;
            this.btnUpdateDeleteMarksA.Click += new System.EventHandler(this.BtnUpdateDeleteMarksA_Click);
            // 
            // btnStudentResultsheetA
            // 
            this.btnStudentResultsheetA.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnStudentResultsheetA.Location = new System.Drawing.Point(11, 112);
            this.btnStudentResultsheetA.Name = "btnStudentResultsheetA";
            this.btnStudentResultsheetA.Size = new System.Drawing.Size(235, 35);
            this.btnStudentResultsheetA.TabIndex = 19;
            this.btnStudentResultsheetA.Text = "Student ResultSheet";
            this.btnStudentResultsheetA.UseVisualStyleBackColor = false;
            this.btnStudentResultsheetA.Click += new System.EventHandler(this.BtnStudentResultsheetA_Click);
            // 
            // btnClassResultSheetA
            // 
            this.btnClassResultSheetA.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnClassResultSheetA.Location = new System.Drawing.Point(11, 148);
            this.btnClassResultSheetA.Name = "btnClassResultSheetA";
            this.btnClassResultSheetA.Size = new System.Drawing.Size(235, 35);
            this.btnClassResultSheetA.TabIndex = 19;
            this.btnClassResultSheetA.Text = "Class ResultSheet";
            this.btnClassResultSheetA.UseVisualStyleBackColor = false;
            this.btnClassResultSheetA.Click += new System.EventHandler(this.BtnClassResultSheetA_Click);
            // 
            // btnSectionResultSheetA
            // 
            this.btnSectionResultSheetA.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnSectionResultSheetA.Location = new System.Drawing.Point(11, 184);
            this.btnSectionResultSheetA.Name = "btnSectionResultSheetA";
            this.btnSectionResultSheetA.Size = new System.Drawing.Size(235, 35);
            this.btnSectionResultSheetA.TabIndex = 20;
            this.btnSectionResultSheetA.Text = "Section ResultSheet";
            this.btnSectionResultSheetA.UseVisualStyleBackColor = false;
            this.btnSectionResultSheetA.Click += new System.EventHandler(this.BtnSectionResultSheetA_Click);
            // 
            // btnUpdateDeleteTimetableA
            // 
            this.btnUpdateDeleteTimetableA.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnUpdateDeleteTimetableA.Location = new System.Drawing.Point(11, 292);
            this.btnUpdateDeleteTimetableA.Name = "btnUpdateDeleteTimetableA";
            this.btnUpdateDeleteTimetableA.Size = new System.Drawing.Size(235, 35);
            this.btnUpdateDeleteTimetableA.TabIndex = 20;
            this.btnUpdateDeleteTimetableA.Text = "Update / DeleteTimetable";
            this.btnUpdateDeleteTimetableA.UseVisualStyleBackColor = false;
            this.btnUpdateDeleteTimetableA.Click += new System.EventHandler(this.BtnUpdateDeleteTimetableA_Click);
            // 
            // AddMarks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1262, 673);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "AddMarks";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Marks";
            this.Load += new System.EventHandler(this.AddMarks_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbRegNo;
        private System.Windows.Forms.Label lbSubName;
        private System.Windows.Forms.Label lbExam;
        private System.Windows.Forms.Label lbMarks;
        private System.Windows.Forms.Label lbYear;
        private System.Windows.Forms.TextBox tbRegNo;
        private System.Windows.Forms.TextBox tbMarks;
        private System.Windows.Forms.TextBox tbSubName;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox cmbExam;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.TextBox tbSearch;
        private System.Windows.Forms.Label lbSearch;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnTeachersHomeA;
        private System.Windows.Forms.Button btnManageMarksA;
        private System.Windows.Forms.Button btnAddTimetableA;
        private System.Windows.Forms.Button btnManageTimetableA;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnUpdateDeleteMarksA;
        private System.Windows.Forms.Button btnStudentResultsheetA;
        private System.Windows.Forms.Button btnClassResultSheetA;
        private System.Windows.Forms.Button btnSectionResultSheetA;
        private System.Windows.Forms.Button btnUpdateDeleteTimetableA;
    }
}