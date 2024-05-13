namespace PoS
{
    partial class ProductsViewForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvProducts = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.Search = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dvgSno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dvgId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dvgName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dvgPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dvgCat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dvgDel = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvProducts
            // 
            this.dgvProducts.AllowUserToAddRows = false;
            this.dgvProducts.AllowUserToDeleteRows = false;
            this.dgvProducts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProducts.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProducts.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProducts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dvgSno,
            this.dvgId,
            this.dvgName,
            this.dvgPrice,
            this.dvgCat,
            this.dvgDel});
            this.dgvProducts.Location = new System.Drawing.Point(48, 127);
            this.dgvProducts.Name = "dgvProducts";
            this.dgvProducts.ReadOnly = true;
            this.dgvProducts.RowHeadersVisible = false;
            this.dgvProducts.Size = new System.Drawing.Size(549, 255);
            this.dgvProducts.TabIndex = 11;
            this.dgvProducts.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProducts_CellContentClick);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Location = new System.Drawing.Point(48, 118);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(550, 2);
            this.panel1.TabIndex = 10;
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(348, 85);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(249, 26);
            this.txtSearch.TabIndex = 9;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // Search
            // 
            this.Search.AutoSize = true;
            this.Search.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Search.Location = new System.Drawing.Point(344, 62);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(60, 20);
            this.Search.TabIndex = 8;
            this.Search.Text = "Search";
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.Transparent;
            this.btnAdd.Location = new System.Drawing.Point(48, 65);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(53, 46);
            this.btnAdd.TabIndex = 7;
            this.btnAdd.Text = "ADD";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(44, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Product List";
            // 
            // dvgSno
            // 
            this.dvgSno.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dvgSno.FillWeight = 70F;
            this.dvgSno.HeaderText = "Sr#";
            this.dvgSno.MinimumWidth = 70;
            this.dvgSno.Name = "dvgSno";
            this.dvgSno.ReadOnly = true;
            this.dvgSno.Visible = false;
            this.dvgSno.Width = 194;
            // 
            // dvgId
            // 
            this.dvgId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dvgId.FillWeight = 70F;
            this.dvgId.HeaderText = "ID";
            this.dvgId.MinimumWidth = 70;
            this.dvgId.Name = "dvgId";
            this.dvgId.ReadOnly = true;
            this.dvgId.Width = 70;
            // 
            // dvgName
            // 
            this.dvgName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dvgName.FillWeight = 70F;
            this.dvgName.HeaderText = "Name";
            this.dvgName.MinimumWidth = 70;
            this.dvgName.Name = "dvgName";
            this.dvgName.ReadOnly = true;
            this.dvgName.Width = 200;
            // 
            // dvgPrice
            // 
            this.dvgPrice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dvgPrice.HeaderText = "Price";
            this.dvgPrice.Name = "dvgPrice";
            this.dvgPrice.ReadOnly = true;
            this.dvgPrice.Width = 75;
            // 
            // dvgCat
            // 
            this.dvgCat.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dvgCat.HeaderText = "Category";
            this.dvgCat.Name = "dvgCat";
            this.dvgCat.ReadOnly = true;
            // 
            // dvgDel
            // 
            this.dvgDel.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dvgDel.HeaderText = "Delete";
            this.dvgDel.Name = "dvgDel";
            this.dvgDel.ReadOnly = true;
            this.dvgDel.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dvgDel.Text = "Delete";
            this.dvgDel.UseColumnTextForButtonValue = true;
            // 
            // ProductsViewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(630, 453);
            this.Controls.Add(this.dgvProducts);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.Search);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.label1);
            this.Name = "ProductsViewForm";
            this.Text = "ProductsViewForm";
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvProducts;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label Search;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dvgSno;
        private System.Windows.Forms.DataGridViewTextBoxColumn dvgId;
        private System.Windows.Forms.DataGridViewTextBoxColumn dvgName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dvgPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn dvgCat;
        private System.Windows.Forms.DataGridViewButtonColumn dvgDel;
    }
}