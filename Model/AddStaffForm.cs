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

namespace PoS.Model
{
    public partial class AddStaffForm : Form
    {
        public AddStaffForm()
        {
            InitializeComponent();
        }

        //private const string staffFilePath = @"C:\Users\bludr\Desktop\MSIT\ISDS 505\Project\5-9\Project\Project\staff.txt";

        private StaffViewForm staffViewForm;

        public AddStaffForm(StaffViewForm staffViewForm)
        {
            InitializeComponent();
            // Center the form on the screen
            this.CenterToScreen();
            this.staffViewForm = staffViewForm;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // Read input values from the text boxes
            string name = txtName.Text.Trim();
            string phone = txtPhone.Text.Trim();
            string role = cbRole.Text.Trim();

            // Validate input (you can add more validation as needed)

            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(phone) || string.IsNullOrEmpty(role))
            {
                MessageBox.Show("Please fill in all fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                // Read all lines from the staff file to get the next ID
                string[] lines = File.ReadAllLines("staff.txt");
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
                using (StreamWriter writer = File.AppendText("staff.txt"))
                {
                    writer.WriteLine($"{nextId},{name},{phone},{role}");
                }

                MessageBox.Show("Staff data saved successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
            }

            catch (Exception ex)
            {
                MessageBox.Show(this, $"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
 