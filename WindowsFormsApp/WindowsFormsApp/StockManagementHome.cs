using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp
{
    public partial class StockManagementHome : Form
    {
        public StockManagementHome()
        {
            InitializeComponent();
        }

        private void CategorySetup_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {


            CategorySetupForm categorySetupForm = new CategorySetupForm();
            categorySetupForm.Show();
            this.Hide();

        }





        private void SearchItemSummary_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {



            SearchItemSummaryForm searchItemSummaryForm = new SearchItemSummaryForm();
            searchItemSummaryForm.Show();
            this.Hide();
        }

        private void CompanySetup_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }
    }
}
