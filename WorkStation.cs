using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PoS
{
    public partial class WorkStation : Form
    {
        public WorkStation()
        {
            InitializeComponent();
        }

        private void btnViewCategories_Click(object sender, EventArgs e)
        {
            // Create an instance of CategoryViewForm
            CategoryViewForm categoryViewForm = new CategoryViewForm();

            // Show the CategoryViewForm
            categoryViewForm.ShowDialog(this);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // Create an instance of PoSForm
            PoSForm poSForm = new PoSForm();

            // Show the PoSForm
            poSForm.ShowDialog(this);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Create an instance of StaffViewForm
            StaffViewForm staffViewForm = new StaffViewForm();

            // Show the StaffViewForm
            staffViewForm.ShowDialog(this);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            // Create an instance of Reports
            Reports reports = new Reports();

            // Show the Reports
            reports.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Create an instance of ProductViewForm
            ProductsViewForm productsViewForm = new ProductsViewForm();

            // Show the ProductViewForm
            productsViewForm.ShowDialog(this);
        }
    }
}
