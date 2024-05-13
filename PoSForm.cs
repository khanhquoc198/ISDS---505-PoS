using PoS.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.LinkLabel;

namespace PoS
{
    public partial class PoSForm : Form
    {
        private string id;
        private string name;
        private string cat;
        private string price;

        public PoSForm()
        {
            InitializeComponent();
        }

        public int MainID = 0;
        int orderNum = 1;

        private void PoSForm_Load(object sender, EventArgs e)
        {
            dataGridView1.BorderStyle = BorderStyle.FixedSingle;
            AddCategory();

            ProductPanel.Controls.Clear();
            LoadProducts();

            lblOrderNum.Text = "Oder Number#" + orderNum;
        }

        private void AddCategory()
        {
            // Path to my categories text file
            string[] categories = File.ReadAllLines("categories.txt");

            CategoryPanel.Controls.Clear();

            foreach (string categoryData in categories)
            {
                // Split each category data to extract the category name
                string[] categoryParts = categoryData.Split(',');
                if (categoryParts.Length >= 2)
                {
                    string categoryName = categoryParts[1].Trim();

                    // Create a new button for the category
                    Button categoryButton = new Button();
                    categoryButton.BackColor = Color.White;
                    categoryButton.Size = new Size(118, 54);
                    categoryButton.Text = categoryName;

                    // Event for click 
                    categoryButton.Click += new EventHandler(_Click);
                    // Add the button to the panel
                    CategoryPanel.Controls.Add(categoryButton);
                }
            }
        }

        private void _Click(object sender, EventArgs e)
        {
            Button categoryButton = (Button)sender;
            foreach (var item in ProductPanel.Controls)
            {
                var pro = (ucProduct)item;
                pro.Visible = pro.PCategory.ToLower().Equals(categoryButton.Text.Trim().ToLower());
            }
        }

        private void AddItems(string id, string name, string cat, string price)
        {
            var w = new ucProduct()
            {
                PName = name,
                PPrice = price,
                PCategory = cat,
                id = Convert.ToInt32(id)
            };

            ProductPanel.Controls.Add(w);

            w.onSelect += (ss, ee) =>
            {
                var wdg = (ucProduct)ss;

                bool productFound = false;

                foreach (DataGridViewRow item in dataGridView1.Rows)
                {
                    if (Convert.ToInt32(item.Cells["dgvID"].Value) == wdg.id)
                    {
                        // Update quantity and amount
                        int qty = Convert.ToInt32(item.Cells["dgvQty"].Value) + 1;
                        item.Cells["dgvQty"].Value = qty;

                        double pricePerUnit;
                        if (double.TryParse(item.Cells["dgvPrice"].Value.ToString(), out pricePerUnit))
                        {
                            double amount = qty * pricePerUnit;
                            item.Cells["dgvAmount"].Value = amount;
                            AddToTotal(amount); // Add the new amount to the total
                        }
                        else
                        {
                            // Handle parsing failure
                            // For example, log an error or display a message
                            Console.WriteLine($"Failed to parse price for item ID {wdg.id}");
                        }

                        productFound = true;
                        break; // Exit loop since product is found
                    }
                }

                if (!productFound)
                {
                    // Add new product
                    double pricePerUnit;
                    if (double.TryParse(wdg.PPrice, out pricePerUnit))
                    {
                        double amount = pricePerUnit;
                        dataGridView1.Rows.Add(new object[] { wdg.id, wdg.PName, 1, pricePerUnit, amount });
                        AddToTotal(amount); // Add the new amount to the total
                    }
                    else
                    {
                        // Handle parsing failure
                        // For example, log an error or display a message
                        Console.WriteLine($"Failed to parse price for new item ID {wdg.id}");
                    }
                }
            };
        }

        // Getting product from text file
        private void LoadProducts()
        {
            string[] products = File.ReadAllLines("products.txt");

            foreach (string productData in products)
            {
                // Split each category data to extract the category name
                string[] productParts = productData.Split(',');
                if (productParts.Length >= 4)
                {   
                    string id = productParts[0].Trim();
                    string name = productParts[1].Trim();
                    string price = productParts[2].Trim();
                    string cat = productParts[3].Trim();

                    AddItems(id, name, cat, price); 
                }
            }
        }

        private void AddToTotal(double amount)
        {
            double tax = 8.75;
            double q;
            // Add the amount of the added item to the subtotal
            if (double.TryParse(lblSub.Text, NumberStyles.Currency, CultureInfo.CurrentCulture, out double subtotal))
            {
                subtotal += amount;
                lblSub.Text = subtotal.ToString("C2", CultureInfo.CurrentCulture);
                lblTax.Text = String.Format("{0:C2}", (subtotal * tax) / 100);
                q = (subtotal * tax) / 100;
                lblTotal.Text = String.Format("{0:C2}", (subtotal + q));
            }
            else
            {
                // Handle parsing failure
                // For example, log an error or display a message
                Console.WriteLine("Failed to parse total amount.");
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            MainID = 0;
            lblSub.Text = "0.00";
            lblTax.Text = "0.00";
            lblTotal.Text = "0.00";
            lblPayment.Text = "Payment Method";
            lblOrderNum.Text = "Order Number #" + orderNum++;
        }

        private void btnCheckOut_Click(object sender, EventArgs e)
        {
            if (lblPayment.Text == "Cash")
            {
                String message = "Payment Successfully Processed.";
                MessageBox.Show(message);
                lblSub.Text = "0.00";
                lblTax.Text = "0.00";
                lblTotal.Text = "0.00";
                lblPayment.Text = "Payment Method";
                lblOrderNum.Text = "Order Number #" + orderNum++;
                dataGridView1.Rows.Clear();
            }
            else if (lblPayment.Text == "Debit" ||  lblPayment.Text == "Credit")
            {
                String message = "Payment Successfully Processed.";
                MessageBox.Show(message);
                lblSub.Text = "0.00";
                lblTax.Text = "0.00";
                lblTotal.Text = "0.00";
                lblPayment.Text = "Payment Method";
                lblOrderNum.Text = "Order Number #" + orderNum++;
                dataGridView1.Rows.Clear();
            }
            else
            {
                String message = "Please select a payment method!";
                MessageBox.Show(message);
            }
        }
    }
}
