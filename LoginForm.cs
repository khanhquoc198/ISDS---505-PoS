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
    public partial class Login : Form
    {
        //private const string filePath = @"C:\Users\bludr\Desktop\MSIT\ISDS 505\Project\5-9\Project\Project\user_credentials.txt";
        //private const string logFilePath = @"C:\Users\bludr\Desktop\MSIT\ISDS 505\Project\5-9\Project\Project\login_log.txt";
        public Login()
        {
            InitializeComponent();

            // Populate the Role ComboBox
            comboBox1.Items.Add("Manager");
            comboBox1.Items.Add("Staff");
            comboBox1.SelectedIndex = 0; // Default selection to Manager
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                DateTime today = DateTime.Now;
                DateTimetoolStripStatusLabel2.Text = today.ToShortDateString();
                TimetoolStripStatusLabel4.Text = today.ToShortTimeString();
            }
            catch (Exception ex)
            {

            }
        }

        private void Login_Load(object sender, EventArgs e)
        {
            // VisibleMenu();
            timer1.Start();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;
            string selectedRole = comboBox1.SelectedItem.ToString();

            try
            {
                string[] lines = File.ReadAllLines("user_credentials.txt");

                foreach (string line in lines)
                {
                    string[] parts = line.Split(',');

                    if (parts.Length == 3)
                    {
                        string storedUsername = parts[0].Trim();
                        string storedPassword = parts[1].Trim();
                        string storedRole = parts[2].Trim();

                        if (selectedRole == storedRole && username == storedUsername && password == storedPassword)
                        {
                            // Successful login
                            string logEntry = $"User: {storedUsername}, Role: {selectedRole}, Login Time: {DateTime.Now}";

                            // Write the log entry to the log file
                            using (StreamWriter writer = File.AppendText("login_log.txt"))
                            {
                                writer.WriteLine(logEntry);
                            }

                            // Hide the login form
                            this.Hide();

                            // Create an instance of the workstation form
                            WorkStation WorkStation = new WorkStation();
                            WorkStation.Closed += (s, args) => this.Close(); // Close the entire application when workstation form is closed
                            WorkStation.Show();

                             // Add code here to open the window based on the role or perform other actions upon successful login
                            return;
                        }
                    }
                }

                MessageBox.Show(this, "Invalid username or password. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (FileNotFoundException)
            {
                MessageBox.Show(this, "User credentials file not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, $"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

