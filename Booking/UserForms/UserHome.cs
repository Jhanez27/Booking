﻿using Booking.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Booking.UserForms
{
    public partial class UserHome : Form
    {
        private Query query;
        private User currentUser;
        public UserHome(User user)
        {
            InitializeComponent();
            currentUser = user;
        }

        private void UserHome_Load(object sender, EventArgs e)
        {
            query = new Query();
            current_user.Text = currentUser.Username;
            dashBoardControl dbs = new dashBoardControl(currentUser);
            dashboardMain_panel.Controls.Add(dbs);
        }
        
        private void minimize_btn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void exit_btn_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void logout_btn_Click(object sender, EventArgs e)
        {
            currentUser = null;
            new Home().Show();
            this.Close();
        }

        private void home_btn_Click(object sender, EventArgs e)
        {
            dashBoardControl dbs = new dashBoardControl(currentUser);
            dashboardMain_panel.Controls.Add(dbs);

        }

       

      
    }
}
