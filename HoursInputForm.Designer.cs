﻿using System;
using System.IO;
using System.Windows.Forms;

namespace PoS
{
    public partial class HoursInputForm : Form
    {
        private string username; // To store the username of the logged-in user
        private DateTimePicker HIFdateTimePicker;
        private TextBox HIFtextBox;
       

        public HoursInputForm(string username)
        {
            InitializeComponent();
            this.username = username;
        }

        private void InitializeComponent()
        {
            this.HIFDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.HIFTextBox = new System.Windows.Forms.TextBox();
            this.hrsWorkedTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // HIFDateTimePicker
            // 
            this.HIFDateTimePicker.Location = new System.Drawing.Point(12, 153);
            this.HIFDateTimePicker.Name = "HIFDateTimePicker";
            this.HIFDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.HIFDateTimePicker.TabIndex = 0;
            // 
            // HIFTextBox
            // 
            this.HIFTextBox.Location = new System.Drawing.Point(334, 153);
            this.HIFTextBox.Name = "HIFTextBox";
            this.HIFTextBox.Size = new System.Drawing.Size(100, 20);
            this.HIFTextBox.TabIndex = 1;
            // 
            // hrsWorkedTextBox
            // 
            this.hrsWorkedTextBox.Location = new System.Drawing.Point(502, 153);
            this.hrsWorkedTextBox.Name = "hrsWorkedTextBox";
            this.hrsWorkedTextBox.Size = new System.Drawing.Size(100, 20);
            this.hrsWorkedTextBox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 130);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Date";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(69)))), ((int)(((byte)(180)))));
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(662, 90);
            this.panel1.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(73, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Input Hours";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PoS.Properties.Resources.more;
            this.pictureBox1.Location = new System.Drawing.Point(21, 23);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(45, 45);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(341, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Username";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(523, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Hours";
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSave.Location = new System.Drawing.Point(502, 276);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(100, 29);
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            // 
            // HoursInputForm
            // 
            this.ClientSize = new System.Drawing.Size(662, 347);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.hrsWorkedTextBox);
            this.Controls.Add(this.HIFTextBox);
            this.Controls.Add(this.HIFDateTimePicker);
            this.Name = "HoursInputForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void HoursInputForm_Load(object sender, EventArgs e)
        {
            // Display the current date
            ((DateTimePicker)HIFdateTimePicker).Value = DateTime.Now.Date;
            // Display the username
            ((TextBox)HIFtextBox).Text = username;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // Get input values
            string date = ((DateTimePicker)HIFdateTimePicker).Value.ToShortDateString();
            string hoursWorked = ((TextBox)hrsWorkedTextBox).Text;

            // Validate input
            if (string.IsNullOrEmpty(hoursWorked))
            {
                MessageBox.Show("Please enter the hours worked.");
                return;
            }

            // Save data to file
            // string filePath = @"C:\Users\bludr\Desktop\MSIT\ISDS 505\Project\Project 4_23\Group project\Group project\Project\hours_data.txt";
            try
            {
                using (StreamWriter writer = new StreamWriter("staff.txt", true))
                {
                    writer.WriteLine($"{date},{username},{hoursWorked}");
                }
                MessageBox.Show("Hours recorded successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error recording hours: " + ex.Message);
            }
        }

        private DateTimePicker HIFDateTimePicker;
        private TextBox HIFTextBox;
        private TextBox hrsWorkedTextBox;
        private Label label1;
        private Panel panel1;
        private Label label2;
        private PictureBox pictureBox1;
        private Label label3;
        private Label label4;
        private Button btnSave;
    }
}