﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Nusantara.Data;
using Nusantara.Models;

namespace Nusantara.Forms
{
    public partial class TerminologiPage : UserControl
    {
        private Member? loggedMember;
        public TerminologiPage(Member? member)
        {
            InitializeComponent();
            loggedMember = member;
        }
        private async void TerminologiPage_Load(object sender, EventArgs e)
        {
            AppDbContext context = new AppDbContext();
            ConfigurationService configService = new ConfigurationService(db);
            Configuration? configuration = await service.GetConfig();
            if (configuration != null)
            {
                labelTerminologi1.Text = configuration.terminologi1;
                labelTerminologi2.Text = configuration.terminologi2;
                labelTerminologi3.Text = configuration.terminologi3;
                labelExchangeRate.Text += "" + configuration.exchangeRate.ToString();
                labelAccessFee.Text += "" + configuration.transferInhousefee.ToString();
                labelInhouseFee.Text += "" + configuration.transferAccrossFee.ToString();
            }
        }
    }
}
