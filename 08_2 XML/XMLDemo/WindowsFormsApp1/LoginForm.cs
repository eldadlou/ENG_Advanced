﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtName.Text =="avi" && txtPass.Text=="123")
            {
                MainForm mainFrm = new MainForm(this, txtName.Text);
                //mainFrm.Show();
                Hide();
                mainFrm.ShowDialog();
            }
            else
            {
                MessageBox.Show("LOGIN FAILED!");
            }
        }

        public string TxtPass
        {
            get { return txtPass.Text; }
        }
    }
}
