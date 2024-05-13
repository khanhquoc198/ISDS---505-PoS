using PoS.Model;
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
    public partial class StaffViewForm : Form
    {
        //private const string staffFilePath = @"C:\Users\bludr\Desktop\MSIT\ISDS 505\Project\5-9\Project\Project\staff.txt";
        public StaffViewForm()
        {
            InitializeComponent();
            // Center the form on the screen
            this.CenterToScreen();

            LoadStaffs();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            // Create an instance of AddStaffForm
            AddStaffForm addStaffForm = new AddStaffForm(this);
            // Show the AddStaffForm as a dialog
            if (addStaffForm.ShowDialog() == DialogResult.OK)
            {
                // Reload categories in StaffViewForm
                LoadStaffs();
            }
        }

        public void LoadStaffs()
        {
            try
            {
                dgvStaff.Rows.Clear();

                // Read all lines from the staff data file
                string[] lines = File.ReadAllLines("staff.txt");
                int id = 1;

                foreach (string line in lines)
                {
                    // Split each line to extract staff details
                    string[] parts = line.Split(',');

                    if (parts.Length >= 3)
                    {
                        // Add the row with staff details to the DataGridView
                        dgvStaff.Rows.Add(id++, parts[0], parts[1], parts[2], parts[3]);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading staff data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvStaff_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                DataGridViewCell clickedCell = dgvStaff.Rows[e.RowIndex].Cells[e.ColumnIndex];

                if (clickedCell is DataGridViewButtonCell)
                {
                    DataGridViewRow row = dgvStaff.Rows[e.RowIndex];
                    int staffId = int.Parse(row.Cells["dvgId"].Value.ToString());
                    string staffName = row.Cells["dvgName"].Value.ToString();

                    DialogResult result = MessageBox.Show($"Are you sure you want to delete the staff '{staffName}'?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (result == DialogResult.Yes)
                    {
                        try
                        {
                            // Remove the staff from the data source and reload the DataGridView
                            DeleteStaff(staffId);
                            LoadStaffs(); // Reload staff data
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"Error deleting staff: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
        }

        private void DeleteStaff(int staffId)
        {
            // Read all lines from the staff file
            List<string> lines = File.ReadAllLines("staff.txt").ToList();

            // Find the staff line to remove
            string staffLine = lines.FirstOrDefault(line => line.StartsWith($"{staffId},"));

            if (staffLine != null)
            {
                // Remove the staff line from the list
                lines.Remove(staffLine);

                // Write the updated lines back to the file
                File.WriteAllLines("staff.txt", lines.ToArray());
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            // Get the search term from the TextBox
            string searchTerm = txtSearch.Text.Trim();

            // If the search term is empty, clear any existing selection and return
            if (string.IsNullOrEmpty(searchTerm))
            {
                dgvStaff.ClearSelection();
                return;
            }

            // Iterate through the rows of the DataGridView
            foreach (DataGridViewRow row in dgvStaff.Rows)
            {
                // Get the value of the cell in the name column
                DataGridViewCell nameCell = row.Cells["dvgName"];

                // Check if the nameCell exists and if its value contains the search term (case-insensitive)
                if (nameCell != null && nameCell.Value != null &&
                    nameCell.Value.ToString().Equals(searchTerm, StringComparison.OrdinalIgnoreCase))
                {
                    // Select the row and scroll it into view
                    row.Selected = true;
                    dgvStaff.FirstDisplayedScrollingRowIndex = row.Index;
                    return; // Exit the method after finding the first match
                }
            }
        }

        private void btnInputHours_Click(object sender, EventArgs e)
        {
            HoursInputForm hoursInputForm = new HoursInputForm();

            hoursInputForm.ShowDialog();
        }
    }
}
