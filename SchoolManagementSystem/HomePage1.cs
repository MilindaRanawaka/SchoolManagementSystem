﻿using System;
using System.Windows.Forms;

namespace SchoolManagementSystem
{
    public partial class HomePage1 : Form
    {
        public HomePage1()
        {
            InitializeComponent();
        }

        private void ListView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void FlowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void MngEvtImgBtn_Click(object sender, EventArgs e)
        {
            EventDashboard eveDash = new EventDashboard();
            this.Hide();
            eveDash.ShowDialog();
        }

        private void MngStaffBtn_Click(object sender, EventArgs e)
        {
            AdminMngStaffHome adminHome = new AdminMngStaffHome();
            this.Hide();
            adminHome.ShowDialog();
        }

        private void MngStaffImgBtn_Click(object sender, EventArgs e)
        {
            AdminMngStaffHome adminHome = new AdminMngStaffHome();
            this.Hide();
            adminHome.ShowDialog();
        }

        private void MngExmBtn_Click(object sender, EventArgs e)
        {
            TeachersHome home = new TeachersHome();
            this.Hide();
            home.ShowDialog();
        }

        private void MngExmImgBtn_Click(object sender, EventArgs e)
        {
            TeachersHome home = new TeachersHome();
            this.Hide();
            home.ShowDialog();
        }

        private void MngResrceImgBtn_Click(object sender, EventArgs e)
        {
            ResourceManageHome resMngHome = new ResourceManageHome();
            this.Hide();
            resMngHome.ShowDialog();
        }

        private void MngResrceBtn_Click(object sender, EventArgs e)
        {
            ResourceManageHome resMngHome = new ResourceManageHome();
            this.Hide();
            resMngHome.ShowDialog();
        }

        private void MngEvtBtn_Click(object sender, EventArgs e)
        {
            EventDashboard eveDash = new EventDashboard();
            this.Hide();
            eveDash.ShowDialog();
        }

        private void MngNticeImgBtn_Click(object sender, EventArgs e)
        {
            Notice_Dashboard newdash = new Notice_Dashboard();
            this.Hide();
            newdash.ShowDialog();
        }

        private void MngNticeBtn_Click(object sender, EventArgs e)
        {
            Notice_Dashboard newdash = new Notice_Dashboard();
            this.Hide();
            newdash.ShowDialog();
        }

        private void MngInvenImgBtn_Click(object sender, EventArgs e)
        {
            InventoryDashboard incDash = new InventoryDashboard();
            this.Hide();
            incDash.ShowDialog();
        }

        private void MngInvenBtn_Click(object sender, EventArgs e)
        {
            InventoryDashboard incDash = new InventoryDashboard();
            this.Hide();
            incDash.ShowDialog();
        }
    }
}
