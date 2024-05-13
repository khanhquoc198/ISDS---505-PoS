using PoS.View;
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
    public partial class Reports : Form
    {
        public Reports()
        {
            InitializeComponent();

            this.CenterToScreen();
        }

        private void btnInventoryReport_Click(object sender, EventArgs e)
        {
            InventoryReportForm inventoryReportForm = new InventoryReportForm();

            inventoryReportForm.ShowDialog();
        }

        private void btnSalesReport_Click(object sender, EventArgs e)
        {
            SalesReportForm salesReportForm = new SalesReportForm();

            salesReportForm.ShowDialog();
        }

        private void btnStaffReport_Click(object sender, EventArgs e)
        {
            StaffReportForm staffReportForm = new StaffReportForm();

            staffReportForm.ShowDialog();
        }
    }
}
