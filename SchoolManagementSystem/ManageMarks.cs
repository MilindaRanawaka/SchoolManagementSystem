﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolManagementSystem
{
    public partial class ManageMarks : Form
    {
        public ManageMarks()
        {
            InitializeComponent();
        }

        private void BtnAddMarks_Click(object sender, EventArgs e)
        {

            AddMarks addMarks = new AddMarks();
            this.Hide();
            addMarks.ShowDialog();
        }

        private void BtnTeachersHomeM_Click(object sender, EventArgs e)
        {
            TeachersHome Mm = new TeachersHome();
            this.Hide();
            Mm.ShowDialog();
        }

        private void BtnAddTimetableM_Click(object sender, EventArgs e)
        {

            AddTimetable att = new AddTimetable();
            this.Hide();
            att.ShowDialog();
        }

        private void Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BtnDeleteUpdate_Click(object sender, EventArgs e)
        {
            UpdateORDeleteMarks ud = new UpdateORDeleteMarks();
            this.Hide();
            ud.ShowDialog();
        }

        private void BtnUpdateTimeTable_Click(object sender, EventArgs e)
        {
            UpdateOrDeleteTimetable udtt = new UpdateOrDeleteTimetable();
            this.Hide();
            udtt.ShowDialog();
        }

        private void BtnRSstudent_Click(object sender, EventArgs e)
        {
            StudentResultSheet stdRS = new StudentResultSheet();
            this.Hide();
            stdRS.ShowDialog();
        }

        private void BtnRSclass_Click(object sender, EventArgs e)
        {
            ClassResultSheet clzRS = new ClassResultSheet();
            this.Hide();
            clzRS.ShowDialog();

        }

        private void BtnRSsection_Click(object sender, EventArgs e)
        {
            SectionResultSheet secRS = new SectionResultSheet();
            this.Hide();
            secRS.ShowDialog();
        }

        private void BtnDeleteTimetableM_Click(object sender, EventArgs e)
        {
            UpdateOrDeleteTimetable udtt = new UpdateOrDeleteTimetable();
            this.Hide();
            udtt.ShowDialog();
        }

        private void BtnManageTimetableM_Click(object sender, EventArgs e)
        {

            ViewTimetable vtt = new ViewTimetable();
            this.Hide();
            vtt.ShowDialog();
        }

        private void BtnUpdateDeleteTimetableM_Click(object sender, EventArgs e)
        {
            UpdateOrDeleteTimetable udtt = new UpdateOrDeleteTimetable();
            this.Hide();
            udtt.ShowDialog();
        }
    }
}
