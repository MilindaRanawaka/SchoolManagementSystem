﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolManagementSystem
{
    class Connection
    {
        public SqlConnection con;
        public string str;

        public Connection()
        {
            try
            {
                str = @"Data Source=LAPTOP-7DMUT13V\ASHANI;Initial Catalog=SchoolManagementSystemDB;Integrated Security=True";
                con = new SqlConnection(str);
                con.Open();
                //MessageBox.Show("DataBase connected");

            }
            catch (SqlException e)
            {
                MessageBox.Show(e.Message);

            }
        }
    }
}
