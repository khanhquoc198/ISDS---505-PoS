using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Security;
using System.Windows.Forms;

namespace PoS.Model
{
    public partial class AddProductForm : Form
    {
        private ProductsViewForm ProductViewForm;

        public AddProductForm(ProductsViewForm productsViewForm)
        {
            InitializeComponent();
            // Center the form on the screen
            this.CenterToScreen();
            this.ProductViewForm = productsViewForm;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // Get input from TextBox controls
            string name = txtName.Text.Trim();
            string price = txtPhone.Text.Trim();
            string cat = cbCat.Text.Trim();
            // Validate input (you can add more validation as needed)

            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(price) || string.IsNullOrEmpty(cat))
            {
                MessageBox.Show("Please fill in all fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                // Read all lines from the staff file to get the next ID
                string[] lines = File.ReadAllLines("products.txt");
                int nextId;

                // Check if the file is empty
                if (lines.Length == 0)
                {
                    // If the file is empty, start with ID 1
                    nextId = 1;
                }
                else
                {
                    // Get the maximum valid ID from the existing lines
                    int maxId = lines.Where(line => int.TryParse(line.Split(',')[0], out _))
                                      .Select(line => int.Parse(line.Split(',')[0]))
                                      .DefaultIfEmpty()
                                      .Max();
                    nextId = maxId + 1;
                }

                // Append the new staff entry to the text file
                using (StreamWriter writer = File.AppendText("products.txt"))
                {
                    writer.WriteLine($"{nextId},{name},{price},{cat}");
                }

                MessageBox.Show("Product data saved successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
            }

            catch (Exception ex)
            {
                MessageBox.Show(this, $"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
