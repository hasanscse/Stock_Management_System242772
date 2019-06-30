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
    public partial class SearchItemSummaryForm : Form
    {
        public SearchItemSummaryForm()
        {
            InitializeComponent();
        }




        private void Back_Click(object sender, EventArgs e)
        {
               StockManagementHome stockManagementHome = new StockManagementHome();
                stockManagementHome.Show();
               this.Hide();            
        }
    }
}
