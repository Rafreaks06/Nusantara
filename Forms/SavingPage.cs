using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Nusantara.Data;

namespace Nusantara.Forms
{
    public partial class SavingPage : UserControl
    {
        public SavingPage()
        {
            InitializeComponent();
        }

        private void txtAdmin_Fee_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblMin_Amount_Click(object sender, EventArgs e)
        {

        }

        private void lblDocument_KK_Click(object sender, EventArgs e)
        {

        }

        private void txtAmount_TextChanged(object sender, EventArgs e)
        {

        }

        private void SavingPage_Load(object sender, EventArgs e)
        {
            private void buttonNewSaving_Click(object sender, EventArgs e)
        {
            SetDefaultField();
            ResetField();
            buttonApply.Enabled = true;
            cmbSaving_Type.SelectedIndex = 0;
            cmbSaving_Type.Enabled = true;
        }

        private void buttonReload_Click_1(object sender, EventArgs e)
        {
            AppDbContext db = new AppDbContext();

            SetSavingDropDown(db);
            SetDefaultField();
            ResetField();

            LoadSavingGrid(db);
        }

    }
}
}
