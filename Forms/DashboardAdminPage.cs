﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Nusantara.Models;

namespace Nusantara.Forms
{
    public partial class DashboardAdminPage : UserControl
    {
        private Member? loggedMember;
        public DashboardAdminPage(Member? member)
        {
            InitializeComponent();
            loggedMember = member;
        }

        private void DashboardAdminPage_Load(object sender, EventArgs e)
        {

        }
    }
}
