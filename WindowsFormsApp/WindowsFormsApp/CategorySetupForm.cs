using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CategorySetup.BLL;
using CategorySetup.Models;


namespace WindowsFormsApp
{
    public partial class CategorySetupForm : Form
    {

        CategoryManager _categoryManager = new CategoryManager();
        private Category category;

        public CategorySetupForm()
        {
            InitializeComponent();
            category = new Category();
        }

        private void Back_Click(object sender, EventArgs e)
        {
            StockManagementHome stockManagementHome = new StockManagementHome();
            stockManagementHome.Show();

            this.Hide();
        }

        private void Save_Click(object sender, EventArgs e)
        {
            category.CategoryName =CategoryNameTextBox.Text;
            int isExecuted;
            isExecuted = _categoryManager.Insert(category);


        }

        private void showButton_Click(object sender, EventArgs e)
        {
            dataGridView.DataSource = _categoryManager.ShowCategory();

        }
    }
}
