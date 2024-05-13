namespace PoS
{
    partial class StaffViewForm
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
            this.dgvStaff = new System.Windows.Forms.DataGridView();
            this.dvgSno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dvgId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dvgName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dvgPhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dvgRole = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dvgDel = new System.Windows.Forms.DataGridViewButtonColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.Search = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnInputHours = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStaff)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvStaff
            // 
            this.dgvStaff.AllowUserToAddRows = false;
            this.dgvStaff.AllowUserToDeleteRows = false;
            this.dgvStaff.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvStaff.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvStaff.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvStaff.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStaff.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dvgSno,
            this.dvgId,
            this.dvgName,
            this.dvgPhone,
            this.dvgRole,
            this.dvgDel});
            this.dgvStaff.Location = new System.Drawing.Point(48, 127);
            this.dgvStaff.Name = "dgvStaff";
            this.dgvStaff.ReadOnly = true;
            this.dgvStaff.RowHeadersVisible = false;
            this.dgvStaff.Size = new System.Drawing.Size(708, 293);
            this.dgvStaff.TabIndex = 11;
            this.dgvStaff.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvStaff_CellContentClick);
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
            this.dvgName.Width = 220;
            // 
            // dvgPhone
            // 
            this.dvgPhone.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dvgPhone.HeaderText = "Phone";
            this.dvgPhone.Name = "dvgPhone";
            this.dvgPhone.ReadOnly = true;
            this.dvgPhone.Width = 170;
            // 
            // dvgRole
            // 
            this.dvgRole.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dvgRole.HeaderText = "Role";
            this.dvgRole.Name = "dvgRole";
            this.dvgRole.ReadOnly = true;
            this.dvgRole.Width = 150;
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
            this.dvgDel.Width = 92;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Location = new System.Drawing.Point(48, 118);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(708, 2);
            this.panel1.TabIndex = 10;
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(507, 85);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(249, 26);
            this.txtSearch.TabIndex = 9;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // Search
            // 
            this.Search.AutoSize = true;
            this.Search.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Search.Location = new System.Drawing.Point(503, 56);
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
            this.label1.Size = new System.Drawing.Size(73, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Staff List";
            // 
            // btnInputHours
            // 
            this.btnInputHours.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnInputHours.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInputHours.ForeColor = System.Drawing.Color.Transparent;
            this.btnInputHours.Location = new System.Drawing.Point(107, 65);
            this.btnInputHours.Name = "btnInputHours";
            this.btnInputHours.Size = new System.Drawing.Size(124, 46);
            this.btnInputHours.TabIndex = 12;
            this.btnInputHours.Text = "Input Hours";
            this.btnInputHours.UseVisualStyleBackColor = false;
            this.btnInputHours.Click += new System.EventHandler(this.btnInputHours_Click);
            // 
            // StaffViewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnInputHours);
            this.Controls.Add(this.dgvStaff);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.Search);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.label1);
            this.Name = "StaffViewForm";
            this.Text = "StaffViewForm";
            ((System.ComponentModel.ISupportInitialize)(this.dgvStaff)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvStaff;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label Search;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dvgSno;
        private System.Windows.Forms.DataGridViewTextBoxColumn dvgId;
        private System.Windows.Forms.DataGridViewTextBoxColumn dvgName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dvgPhone;
        private System.Windows.Forms.DataGridViewTextBoxColumn dvgRole;
        private System.Windows.Forms.DataGridViewButtonColumn dvgDel;
        private System.Windows.Forms.Button btnInputHours;
    }
}