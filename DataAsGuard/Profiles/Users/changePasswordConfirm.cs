﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataAsGuard.Profiles.Users
{
    public partial class changePasswordConfirm : Form
    {
        public changePasswordConfirm()
        {
            InitializeComponent();
        }

        private void profile_Click(object sender, EventArgs e)
        {
            Profile profile = new Profile();
            profile.Show();
            Hide();
        }
    }
}
