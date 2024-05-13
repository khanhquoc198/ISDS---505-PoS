using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PoS
{
    public partial class AddCategoryForm : Form
    {
        private const string categoriesFilePath = @"C:\Users\Bush\OneDrive\Desktop\MSIT\Spring 2024\ISDS 505\Group project\Project\categories.txt";

        private CategoryViewForm categoryViewForm;

        public AddCategoryForm(CategoryViewForm categoryViewForm)
        {
            InitializeComponent();
            // Center the form on the screen
            this.CenterToScreen();
            this.categoryViewForm = categoryViewForm;
        }


        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // Get input from TextBox controls
            string name = txtName.Text.Trim();

            if (string.IsNullOrWhiteSpace(name))
            {
                MessageBox.Show(this, "Please fill in the box", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                // Read all lines from the categories file to get the next ID
                string[] lines = File.ReadAllLines(categoriesFilePath);
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

                // Append the new category entry to the text file
                using (StreamWriter writer = File.AppendText(categoriesFilePath))
                {
                    writer.WriteLine($"{nextId},{name}");
                }

                MessageBox.Show(this, "Category added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK; // Signal success to CategoryViewForm

            }
            catch (Exception ex)
            {
                MessageBox.Show(this, $"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
