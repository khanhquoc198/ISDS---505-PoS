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
    public partial class CategoryViewForm : Form
    {
        private const string categoriesFilePath = @"C:\Users\Bush\OneDrive\Desktop\MSIT\Spring 2024\ISDS 505\Group project\Project\categories.txt";

        public CategoryViewForm()
        {
            InitializeComponent();
            // Center the form on the screen
            this.CenterToScreen();

            LoadCategories();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            // Create an instance of AddCategoryForm
            AddCategoryForm addCategoryForm = new AddCategoryForm(this);
            // Show the AddCategoryForm as a dialog
            if (addCategoryForm.ShowDialog() == DialogResult.OK)
            {
                // Reload categories in CategoryViewForm
                LoadCategories();
            }
        }

        public void LoadCategories()
        {
            try
            {
                dgvCategories.Rows.Clear();

                // Read all lines from the categories file
                string[] lines = File.ReadAllLines(categoriesFilePath);
                int id = 1;

                foreach (string line in lines)
                {
                    // Split each line into Sr#, ID, Name
                    string[] parts = line.Split(',');

                    if (parts.Length >= 2)
                    {
                        // Add the row with ID starting from 1
                        dgvCategories.Rows.Add(id++, parts[0], parts[1]);
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading categories: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvCategories_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Get the row to be deleted
            DataGridViewRow rowToDelete = dgvCategories.Rows[e.RowIndex];

            // Display confirmation dialog for deletion
            DialogResult result = MessageBox.Show(this, $"Are you sure you want to delete the category '{rowToDelete.Cells["dvgName"].Value}'?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            // If user confirms deletion, proceed with deletion
            if (result == DialogResult.Yes)
            {
                int categoryId;
                string categoryName = rowToDelete.Cells["dvgName"].Value?.ToString() ?? string.Empty;

                // Check if the cell value is null or can be parsed as an integer
                if (rowToDelete.Cells["dvgId"].Value == null || !int.TryParse(rowToDelete.Cells["dvgId"].Value.ToString(), out categoryId))
                {
                    MessageBox.Show(this, "Invalid category ID in the selected row.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                try
                {
                    // Remove the category from the data source
                    DeleteCategory(categoryId, categoryName);

                    // Remove the row from the DataGridView
                    dgvCategories.Rows.RemoveAt(e.RowIndex);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(this, $"Error deleting category: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void DeleteCategory(int categoryId, string categoryName)
        {

            // Read all lines from the categories file
            List<string> lines = File.ReadAllLines(categoriesFilePath).ToList();

            // Find the category line to remove
            string categoryLine = lines.FirstOrDefault(line => line.StartsWith($"{categoryId},{categoryName}"));

            if (categoryLine != null)
            {
                // Remove the category line from the list
                lines.Remove(categoryLine);

                // Write the updated lines back to the file
                File.WriteAllLines(categoriesFilePath, lines.ToArray());
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            // Get the search term from the TextBox
            string searchTerm = txtSearch.Text.Trim();

            // If the search term is empty, clear any existing selection and return
            if (string.IsNullOrEmpty(searchTerm))
            {
                dgvCategories.ClearSelection();
                return;
            }

            // Iterate through the rows of the DataGridView
            foreach (DataGridViewRow row in dgvCategories.Rows)
            {
                // Get the value of the cell in the name column
                DataGridViewCell nameCell = row.Cells["dvgName"];

                // Check if the nameCell exists and if its value contains the search term (case-insensitive)
                if (nameCell != null && nameCell.Value != null &&
                    nameCell.Value.ToString().IndexOf(searchTerm, StringComparison.OrdinalIgnoreCase) >= 0)
                {
                    // Select the row and scroll it into view
                    row.Selected = true;
                    dgvCategories.FirstDisplayedScrollingRowIndex = row.Index;
                    return; // Exit the method after finding the first match
                }
            }
        }
    }
}

