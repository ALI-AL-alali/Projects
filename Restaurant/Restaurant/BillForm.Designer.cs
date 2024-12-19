namespace Restaurant
{
    partial class BillForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BillForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label2 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnclose = new System.Windows.Forms.Button();
            this.btnPrintBill = new System.Windows.Forms.Button();
            this.lblOrderID = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblOrderType = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblTableNumber = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblTotalPrice = new System.Windows.Forms.Label();
            this.dgvOrders = new System.Windows.Forms.DataGridView();
            this.btnBackToCashier = new System.Windows.Forms.Button();
            this.orderDetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrders)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderDetailsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Tahoma", 24.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(-7, 1);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(328, 40);
            this.label2.TabIndex = 28;
            this.label2.Text = "RESTAURANT BILL";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Bold);
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label8.Location = new System.Drawing.Point(342, 191);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(151, 24);
            this.label8.TabIndex = 38;
            this.label8.Text = "المجموع الكلي";
            // 
            // btnclose
            // 
            this.btnclose.BackColor = System.Drawing.Color.Transparent;
            this.btnclose.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnclose.BackgroundImage")));
            this.btnclose.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnclose.ForeColor = System.Drawing.Color.Transparent;
            this.btnclose.Image = ((System.Drawing.Image)(resources.GetObject("btnclose.Image")));
            this.btnclose.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnclose.Location = new System.Drawing.Point(458, 1);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(35, 35);
            this.btnclose.TabIndex = 29;
            this.btnclose.UseVisualStyleBackColor = false;
            this.btnclose.Click += new System.EventHandler(this.btnclose_Click_1);
            // 
            // btnPrintBill
            // 
            this.btnPrintBill.BackColor = System.Drawing.Color.Maroon;
            this.btnPrintBill.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPrintBill.FlatAppearance.BorderSize = 0;
            this.btnPrintBill.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrintBill.Font = new System.Drawing.Font("Gadugi", 15.75F, System.Drawing.FontStyle.Bold);
            this.btnPrintBill.ForeColor = System.Drawing.Color.White;
            this.btnPrintBill.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnPrintBill.Location = new System.Drawing.Point(0, 144);
            this.btnPrintBill.Name = "btnPrintBill";
            this.btnPrintBill.Size = new System.Drawing.Size(231, 36);
            this.btnPrintBill.TabIndex = 30;
            this.btnPrintBill.Text = "طباعة الفاتورة";
            this.btnPrintBill.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnPrintBill.UseVisualStyleBackColor = false;
            this.btnPrintBill.Click += new System.EventHandler(this.btnPrintBill_Click_1);
            // 
            // lblOrderID
            // 
            this.lblOrderID.AutoSize = true;
            this.lblOrderID.BackColor = System.Drawing.Color.Transparent;
            this.lblOrderID.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Bold);
            this.lblOrderID.ForeColor = System.Drawing.Color.White;
            this.lblOrderID.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblOrderID.Location = new System.Drawing.Point(258, 63);
            this.lblOrderID.Name = "lblOrderID";
            this.lblOrderID.Size = new System.Drawing.Size(23, 24);
            this.lblOrderID.TabIndex = 31;
            this.lblOrderID.Text = "0";
            this.lblOrderID.Click += new System.EventHandler(this.lblOrderID_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label3.Location = new System.Drawing.Point(380, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 24);
            this.label3.TabIndex = 32;
            this.label3.Text = "رقم الطلب";
            // 
            // lblOrderType
            // 
            this.lblOrderType.AutoSize = true;
            this.lblOrderType.BackColor = System.Drawing.Color.Transparent;
            this.lblOrderType.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Bold);
            this.lblOrderType.ForeColor = System.Drawing.Color.White;
            this.lblOrderType.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblOrderType.Location = new System.Drawing.Point(261, 107);
            this.lblOrderType.Name = "lblOrderType";
            this.lblOrderType.Size = new System.Drawing.Size(48, 24);
            this.lblOrderType.TabIndex = 33;
            this.lblOrderType.Text = "null";
            this.lblOrderType.Click += new System.EventHandler(this.lblOrderType_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label5.Location = new System.Drawing.Point(383, 107);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 24);
            this.label5.TabIndex = 34;
            this.label5.Text = "نوع الطلب";
            // 
            // lblTableNumber
            // 
            this.lblTableNumber.AutoSize = true;
            this.lblTableNumber.BackColor = System.Drawing.Color.Transparent;
            this.lblTableNumber.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Bold);
            this.lblTableNumber.ForeColor = System.Drawing.Color.White;
            this.lblTableNumber.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblTableNumber.Location = new System.Drawing.Point(258, 149);
            this.lblTableNumber.Name = "lblTableNumber";
            this.lblTableNumber.Size = new System.Drawing.Size(23, 24);
            this.lblTableNumber.TabIndex = 35;
            this.lblTableNumber.Text = "0";
            this.lblTableNumber.Click += new System.EventHandler(this.lblTableNumber_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label7.Location = new System.Drawing.Point(374, 149);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(119, 24);
            this.label7.TabIndex = 36;
            this.label7.Text = "رقم الطاولة";
            // 
            // lblTotalPrice
            // 
            this.lblTotalPrice.AutoSize = true;
            this.lblTotalPrice.BackColor = System.Drawing.Color.Transparent;
            this.lblTotalPrice.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Bold);
            this.lblTotalPrice.ForeColor = System.Drawing.Color.White;
            this.lblTotalPrice.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblTotalPrice.Location = new System.Drawing.Point(208, 191);
            this.lblTotalPrice.Name = "lblTotalPrice";
            this.lblTotalPrice.Size = new System.Drawing.Size(55, 24);
            this.lblTotalPrice.TabIndex = 37;
            this.lblTotalPrice.Text = "0.00";
            this.lblTotalPrice.Click += new System.EventHandler(this.lblTotalPrice_Click);
            // 
            // dgvOrders
            // 
            this.dgvOrders.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvOrders.BackgroundColor = System.Drawing.Color.DimGray;
            this.dgvOrders.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 8F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.InfoText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.MenuBar;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvOrders.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvOrders.ColumnHeadersHeight = 30;
            this.dgvOrders.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.dgvOrders.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dgvOrders.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dgvOrders.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.dgvOrders.Location = new System.Drawing.Point(0, 244);
            this.dgvOrders.Name = "dgvOrders";
            this.dgvOrders.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 8F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvOrders.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvOrders.Size = new System.Drawing.Size(493, 298);
            this.dgvOrders.TabIndex = 27;
            this.dgvOrders.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvOrders_CellContentClick);
            // 
            // btnBackToCashier
            // 
            this.btnBackToCashier.BackColor = System.Drawing.Color.DarkGreen;
            this.btnBackToCashier.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBackToCashier.FlatAppearance.BorderSize = 0;
            this.btnBackToCashier.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBackToCashier.Font = new System.Drawing.Font("Gadugi", 15.75F, System.Drawing.FontStyle.Bold);
            this.btnBackToCashier.ForeColor = System.Drawing.Color.White;
            this.btnBackToCashier.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnBackToCashier.Location = new System.Drawing.Point(0, 95);
            this.btnBackToCashier.Name = "btnBackToCashier";
            this.btnBackToCashier.Size = new System.Drawing.Size(231, 36);
            this.btnBackToCashier.TabIndex = 39;
            this.btnBackToCashier.Text = "العودة الى واجهة الكاشير";
            this.btnBackToCashier.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnBackToCashier.UseVisualStyleBackColor = false;
            this.btnBackToCashier.Click += new System.EventHandler(this.btnBackToCashier_Click);
            // 
            // restaurantDataSet
            // 
            // 
            // orderDetailsBindingSource
            // 
            this.orderDetailsBindingSource.DataMember = "OrderDetails";
            // 
            // orderDetailsTableAdapter
            // 
            // 
            // BillForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(492, 706);
            this.Controls.Add(this.btnBackToCashier);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lblTotalPrice);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lblTableNumber);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblOrderType);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblOrderID);
            this.Controls.Add(this.btnPrintBill);
            this.Controls.Add(this.btnclose);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvOrders);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "BillForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bill";
            this.Load += new System.EventHandler(this.BillForm_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrders)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderDetailsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnclose;
        private System.Windows.Forms.Button btnPrintBill;
        private System.Windows.Forms.Label lblOrderID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblOrderType;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblTableNumber;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblTotalPrice;
        private System.Windows.Forms.Button btnBackToCashier;
        private System.Windows.Forms.BindingSource orderDetailsBindingSource;
        private System.Windows.Forms.DataGridView dgvOrders;
    }
}