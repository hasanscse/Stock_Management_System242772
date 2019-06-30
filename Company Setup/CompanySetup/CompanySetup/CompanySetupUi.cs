using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CompanySetup.BLL;
using CompanySetup.Models;

namespace CompanySetup
{
    public partial class CompanySetupUi : Form
    {
        CompanyManager _companyManager = new CompanyManager();
        private Company company;

        public CompanySetupUi()
        {
            InitializeComponent();
            company = new Company();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            company.CompanyName = companyNameTextBox.Text;
            int isExecuted;
            isExecuted = _companyManager.Insert(company);
        }

        private void showButton_Click(object sender, EventArgs e)
        {
            dataGridView.DataSource = _companyManager.ShowCompany();
        }

       
    }
}
