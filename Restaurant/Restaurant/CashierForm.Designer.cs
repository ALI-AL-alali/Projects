namespace Restaurant
{
    partial class CashierForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CashierForm));
            this.cmbOrderType = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dgvOrderDetails = new System.Windows.Forms.DataGridView();
            this.MealID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MealName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SubTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAddMeal = new System.Windows.Forms.Button();
            this.btnSaveOrder = new System.Windows.Forms.Button();
            this.btnRemoveMeal = new System.Windows.Forms.Button();
            this.cmbMeals = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.numQuantity = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.MaelID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSelectTable = new System.Windows.Forms.Button();
            this.btnclose = new System.Windows.Forms.Button();
            this.Logout = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderDetails)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numQuantity)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbOrderType
            // 
            this.cmbOrderType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbOrderType.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbOrderType.FormattingEnabled = true;
            this.cmbOrderType.Items.AddRange(new object[] {
            "داخلي",
            "خارجي"});
            this.cmbOrderType.Location = new System.Drawing.Point(573, 46);
            this.cmbOrderType.Name = "cmbOrderType";
            this.cmbOrderType.Size = new System.Drawing.Size(130, 27);
            this.cmbOrderType.TabIndex = 7;
            this.cmbOrderType.SelectedIndexChanged += new System.EventHandler(this.cmbOrderType_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Tahoma", 24.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(241, 40);
            this.label2.TabIndex = 8;
            this.label2.Text = "RESTAURANT";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Tahoma", 24.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(247, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(204, 40);
            this.label3.TabIndex = 9;
            this.label3.Text = "FAST FOOD";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(709, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 24);
            this.label1.TabIndex = 10;
            this.label1.Text = "نوع الطلب";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(695, 167);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 24);
            this.label4.TabIndex = 12;
            this.label4.Text = "رقم الطاولة";
            // 
            // dgvOrderDetails
            // 
            this.dgvOrderDetails.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvOrderDetails.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MealID,
            this.MealName,
            this.Price,
            this.Quantity,
            this.SubTotal});
            this.dgvOrderDetails.Location = new System.Drawing.Point(0, 43);
            this.dgvOrderDetails.Name = "dgvOrderDetails";
            this.dgvOrderDetails.Size = new System.Drawing.Size(542, 295);
            this.dgvOrderDetails.TabIndex = 13;
            this.dgvOrderDetails.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvOrderDetails_CellContentClick);
            // 
            // MealID
            // 
            this.MealID.HeaderText = "رقم الوجبة";
            this.MealID.Name = "MealID";
            this.MealID.ReadOnly = true;
            // 
            // MealName
            // 
            this.MealName.HeaderText = "اسم الوجبة";
            this.MealName.Name = "MealName";
            this.MealName.ReadOnly = true;
            // 
            // Price
            // 
            this.Price.HeaderText = "السعر";
            this.Price.Name = "Price";
            this.Price.ReadOnly = true;
            // 
            // Quantity
            // 
            this.Quantity.HeaderText = "الكمية";
            this.Quantity.Name = "Quantity";
            this.Quantity.ReadOnly = true;
            // 
            // SubTotal
            // 
            this.SubTotal.HeaderText = "السعر الاجمالي";
            this.SubTotal.Name = "SubTotal";
            this.SubTotal.ReadOnly = true;
            // 
            // btnAddMeal
            // 
            this.btnAddMeal.BackColor = System.Drawing.Color.Navy;
            this.btnAddMeal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddMeal.FlatAppearance.BorderSize = 0;
            this.btnAddMeal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddMeal.Font = new System.Drawing.Font("Gadugi", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddMeal.ForeColor = System.Drawing.Color.White;
            this.btnAddMeal.Location = new System.Drawing.Point(575, 204);
            this.btnAddMeal.Name = "btnAddMeal";
            this.btnAddMeal.Size = new System.Drawing.Size(231, 36);
            this.btnAddMeal.TabIndex = 14;
            this.btnAddMeal.Text = "إضافة وجبة";
            this.btnAddMeal.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAddMeal.UseVisualStyleBackColor = false;
            this.btnAddMeal.Click += new System.EventHandler(this.btnAddMeal_Click_1);
            // 
            // btnSaveOrder
            // 
            this.btnSaveOrder.BackColor = System.Drawing.Color.DarkGreen;
            this.btnSaveOrder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSaveOrder.FlatAppearance.BorderSize = 0;
            this.btnSaveOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveOrder.Font = new System.Drawing.Font("Gadugi", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveOrder.ForeColor = System.Drawing.Color.White;
            this.btnSaveOrder.Location = new System.Drawing.Point(575, 313);
            this.btnSaveOrder.Name = "btnSaveOrder";
            this.btnSaveOrder.Size = new System.Drawing.Size(231, 36);
            this.btnSaveOrder.TabIndex = 15;
            this.btnSaveOrder.Text = "حفظ الطلب";
            this.btnSaveOrder.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSaveOrder.UseVisualStyleBackColor = false;
            this.btnSaveOrder.Click += new System.EventHandler(this.btnSaveOrder_Click);
            // 
            // btnRemoveMeal
            // 
            this.btnRemoveMeal.BackColor = System.Drawing.Color.Maroon;
            this.btnRemoveMeal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRemoveMeal.FlatAppearance.BorderSize = 0;
            this.btnRemoveMeal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoveMeal.Font = new System.Drawing.Font("Gadugi", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveMeal.ForeColor = System.Drawing.Color.White;
            this.btnRemoveMeal.Location = new System.Drawing.Point(575, 258);
            this.btnRemoveMeal.Name = "btnRemoveMeal";
            this.btnRemoveMeal.Size = new System.Drawing.Size(231, 36);
            this.btnRemoveMeal.TabIndex = 16;
            this.btnRemoveMeal.Text = "حذف وجبة";
            this.btnRemoveMeal.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnRemoveMeal.UseVisualStyleBackColor = false;
            this.btnRemoveMeal.Click += new System.EventHandler(this.btnRemoveMeal_Click);
            // 
            // cmbMeals
            // 
            this.cmbMeals.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMeals.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbMeals.FormattingEnabled = true;
            this.cmbMeals.Location = new System.Drawing.Point(575, 87);
            this.cmbMeals.Name = "cmbMeals";
            this.cmbMeals.Size = new System.Drawing.Size(130, 27);
            this.cmbMeals.TabIndex = 17;
            this.cmbMeals.SelectedIndexChanged += new System.EventHandler(this.cmbMeals_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(733, 86);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 24);
            this.label5.TabIndex = 19;
            this.label5.Text = "الوجبات";
            // 
            // numQuantity
            // 
            this.numQuantity.Font = new System.Drawing.Font("Tahoma", 12F);
            this.numQuantity.Location = new System.Drawing.Point(575, 124);
            this.numQuantity.Name = "numQuantity";
            this.numQuantity.Size = new System.Drawing.Size(130, 27);
            this.numQuantity.TabIndex = 20;
            this.numQuantity.ValueChanged += new System.EventHandler(this.numQuantity_ValueChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(747, 122);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 24);
            this.label6.TabIndex = 21;
            this.label6.Text = "الكمية";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.BackColor = System.Drawing.Color.Black;
            this.lblTotal.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.ForeColor = System.Drawing.Color.White;
            this.lblTotal.Location = new System.Drawing.Point(176, 342);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(55, 24);
            this.lblTotal.TabIndex = 23;
            this.lblTotal.Text = "0.00";
            this.lblTotal.Click += new System.EventHandler(this.lblTotal_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Black;
            this.label8.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(322, 342);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 24);
            this.label8.TabIndex = 24;
            this.label8.Text = "السعر";
            // 
            // MaelID
            // 
            this.MaelID.HeaderText = "MaelID";
            this.MaelID.Name = "MaelID";
            this.MaelID.ReadOnly = true;
            // 
            // btnSelectTable
            // 
            this.btnSelectTable.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnSelectTable.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSelectTable.Enabled = false;
            this.btnSelectTable.FlatAppearance.BorderSize = 0;
            this.btnSelectTable.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelectTable.Font = new System.Drawing.Font("Gadugi", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelectTable.ForeColor = System.Drawing.Color.White;
            this.btnSelectTable.Location = new System.Drawing.Point(573, 158);
            this.btnSelectTable.Name = "btnSelectTable";
            this.btnSelectTable.Size = new System.Drawing.Size(116, 33);
            this.btnSelectTable.TabIndex = 25;
            this.btnSelectTable.Text = "اختيار";
            this.btnSelectTable.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSelectTable.UseVisualStyleBackColor = false;
            this.btnSelectTable.Click += new System.EventHandler(this.btnSelectTable_Click_1);
            // 
            // btnclose
            // 
            this.btnclose.BackColor = System.Drawing.Color.Transparent;
            this.btnclose.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnclose.BackgroundImage")));
            this.btnclose.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnclose.ForeColor = System.Drawing.Color.Transparent;
            this.btnclose.Image = ((System.Drawing.Image)(resources.GetObject("btnclose.Image")));
            this.btnclose.Location = new System.Drawing.Point(781, 0);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(35, 35);
            this.btnclose.TabIndex = 6;
            this.btnclose.UseVisualStyleBackColor = false;
            this.btnclose.Click += new System.EventHandler(this.btnclose_Click);
            // 
            // Logout
            // 
            this.Logout.BackColor = System.Drawing.Color.Transparent;
            this.Logout.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Logout.BackgroundImage")));
            this.Logout.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Logout.ForeColor = System.Drawing.Color.Transparent;
            this.Logout.Location = new System.Drawing.Point(745, 0);
            this.Logout.Name = "Logout";
            this.Logout.Size = new System.Drawing.Size(35, 35);
            this.Logout.TabIndex = 26;
            this.Logout.UseVisualStyleBackColor = false;
            this.Logout.Click += new System.EventHandler(this.Logout_Click);
            // 
            // CashierForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(818, 376);
            this.Controls.Add(this.Logout);
            this.Controls.Add(this.btnSelectTable);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.numQuantity);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmbMeals);
            this.Controls.Add(this.btnRemoveMeal);
            this.Controls.Add(this.btnSaveOrder);
            this.Controls.Add(this.btnAddMeal);
            this.Controls.Add(this.dgvOrderDetails);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbOrderType);
            this.Controls.Add(this.btnclose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CashierForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CashierForm";
            this.Load += new System.EventHandler(this.CashierForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderDetails)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numQuantity)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cmbOrderType;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgvOrderDetails;
        private System.Windows.Forms.Button btnAddMeal;
        private System.Windows.Forms.Button btnSaveOrder;
        private System.Windows.Forms.Button btnRemoveMeal;
        private System.Windows.Forms.ComboBox cmbMeals;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numQuantity;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaelID;
        private System.Windows.Forms.Button btnSelectTable;
        private System.Windows.Forms.DataGridViewTextBoxColumn MealID;
        private System.Windows.Forms.DataGridViewTextBoxColumn MealName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn SubTotal;
        private System.Windows.Forms.Button btnclose;
        private System.Windows.Forms.Button Logout;
    }
}