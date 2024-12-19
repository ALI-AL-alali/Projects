namespace Restaurant
{
    partial class AdminFormTable
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminFormTable));
            this.btnclose = new System.Windows.Forms.Button();
            this.btnRemoveTable = new System.Windows.Forms.Button();
            this.btnEditTable = new System.Windows.Forms.Button();
            this.btnAddTable = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbTableStatus = new System.Windows.Forms.ComboBox();
            this.txtTableNumber = new System.Windows.Forms.TextBox();
            this.dgvTables = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Logout = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTables)).BeginInit();
            this.SuspendLayout();
            // 
            // btnclose
            // 
            this.btnclose.BackColor = System.Drawing.Color.Transparent;
            this.btnclose.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnclose.BackgroundImage")));
            this.btnclose.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnclose.ForeColor = System.Drawing.Color.Transparent;
            this.btnclose.Image = ((System.Drawing.Image)(resources.GetObject("btnclose.Image")));
            this.btnclose.Location = new System.Drawing.Point(643, 0);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(35, 35);
            this.btnclose.TabIndex = 7;
            this.btnclose.UseVisualStyleBackColor = false;
            this.btnclose.Click += new System.EventHandler(this.btnclose_Click);
            // 
            // btnRemoveTable
            // 
            this.btnRemoveTable.BackColor = System.Drawing.Color.Maroon;
            this.btnRemoveTable.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRemoveTable.FlatAppearance.BorderSize = 0;
            this.btnRemoveTable.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoveTable.Font = new System.Drawing.Font("Gadugi", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveTable.ForeColor = System.Drawing.Color.White;
            this.btnRemoveTable.Location = new System.Drawing.Point(358, 267);
            this.btnRemoveTable.Name = "btnRemoveTable";
            this.btnRemoveTable.Size = new System.Drawing.Size(295, 36);
            this.btnRemoveTable.TabIndex = 19;
            this.btnRemoveTable.Text = "حذف طاولة";
            this.btnRemoveTable.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnRemoveTable.UseVisualStyleBackColor = false;
            this.btnRemoveTable.Click += new System.EventHandler(this.btnRemoveTable_Click);
            // 
            // btnEditTable
            // 
            this.btnEditTable.BackColor = System.Drawing.Color.DarkGreen;
            this.btnEditTable.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditTable.FlatAppearance.BorderSize = 0;
            this.btnEditTable.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditTable.Font = new System.Drawing.Font("Gadugi", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditTable.ForeColor = System.Drawing.Color.White;
            this.btnEditTable.Location = new System.Drawing.Point(358, 213);
            this.btnEditTable.Name = "btnEditTable";
            this.btnEditTable.Size = new System.Drawing.Size(295, 36);
            this.btnEditTable.TabIndex = 18;
            this.btnEditTable.Text = "تعديل الطاولة";
            this.btnEditTable.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnEditTable.UseVisualStyleBackColor = false;
            this.btnEditTable.Click += new System.EventHandler(this.btnEditTable_Click);
            // 
            // btnAddTable
            // 
            this.btnAddTable.BackColor = System.Drawing.Color.Navy;
            this.btnAddTable.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddTable.FlatAppearance.BorderSize = 0;
            this.btnAddTable.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddTable.Font = new System.Drawing.Font("Gadugi", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddTable.ForeColor = System.Drawing.Color.White;
            this.btnAddTable.Location = new System.Drawing.Point(358, 161);
            this.btnAddTable.Name = "btnAddTable";
            this.btnAddTable.Size = new System.Drawing.Size(295, 36);
            this.btnAddTable.TabIndex = 17;
            this.btnAddTable.Text = "إضافة طاولة";
            this.btnAddTable.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAddTable.UseVisualStyleBackColor = false;
            this.btnAddTable.Click += new System.EventHandler(this.btnAddTable_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(599, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 24);
            this.label1.TabIndex = 20;
            this.label1.Text = "الحالة";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(557, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 24);
            this.label2.TabIndex = 21;
            this.label2.Text = "رقم الطاولة";
            // 
            // cmbTableStatus
            // 
            this.cmbTableStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTableStatus.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTableStatus.FormattingEnabled = true;
            this.cmbTableStatus.Items.AddRange(new object[] {
            "متوفرة",
            "محجوزة"});
            this.cmbTableStatus.Location = new System.Drawing.Point(358, 91);
            this.cmbTableStatus.Name = "cmbTableStatus";
            this.cmbTableStatus.Size = new System.Drawing.Size(186, 27);
            this.cmbTableStatus.TabIndex = 22;
            // 
            // txtTableNumber
            // 
            this.txtTableNumber.Font = new System.Drawing.Font("Tahoma", 12F);
            this.txtTableNumber.Location = new System.Drawing.Point(358, 47);
            this.txtTableNumber.Name = "txtTableNumber";
            this.txtTableNumber.Size = new System.Drawing.Size(186, 27);
            this.txtTableNumber.TabIndex = 23;
            // 
            // dgvTables
            // 
            this.dgvTables.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTables.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTables.Location = new System.Drawing.Point(1, 59);
            this.dgvTables.Name = "dgvTables";
            this.dgvTables.ReadOnly = true;
            this.dgvTables.Size = new System.Drawing.Size(351, 256);
            this.dgvTables.TabIndex = 26;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Tahoma", 24.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(241, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(204, 40);
            this.label3.TabIndex = 28;
            this.label3.Text = "FAST FOOD";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Tahoma", 24.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(-6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(241, 40);
            this.label4.TabIndex = 27;
            this.label4.Text = "RESTAURANT";
            // 
            // Logout
            // 
            this.Logout.BackColor = System.Drawing.Color.Transparent;
            this.Logout.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Logout.BackgroundImage")));
            this.Logout.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Logout.ForeColor = System.Drawing.Color.Transparent;
            this.Logout.Image = ((System.Drawing.Image)(resources.GetObject("Logout.Image")));
            this.Logout.Location = new System.Drawing.Point(603, 0);
            this.Logout.Name = "Logout";
            this.Logout.Size = new System.Drawing.Size(35, 35);
            this.Logout.TabIndex = 29;
            this.Logout.UseVisualStyleBackColor = false;
            this.Logout.Click += new System.EventHandler(this.Logout_Click);
            // 
            // AdminFormTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(676, 315);
            this.Controls.Add(this.Logout);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dgvTables);
            this.Controls.Add(this.txtTableNumber);
            this.Controls.Add(this.cmbTableStatus);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnRemoveTable);
            this.Controls.Add(this.btnEditTable);
            this.Controls.Add(this.btnAddTable);
            this.Controls.Add(this.btnclose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AdminFormTable";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminFormTable";
            this.Load += new System.EventHandler(this.AdminFormTable_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTables)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnclose;
        private System.Windows.Forms.Button btnRemoveTable;
        private System.Windows.Forms.Button btnEditTable;
        private System.Windows.Forms.Button btnAddTable;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbTableStatus;
        private System.Windows.Forms.TextBox txtTableNumber;
        private System.Windows.Forms.DataGridView dgvTables;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button Logout;
    }
}