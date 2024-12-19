namespace Restaurant
{
    partial class TableForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TableForm));
            this.btnclose = new System.Windows.Forms.Button();
            this.dgvTables = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnShowBill = new System.Windows.Forms.Button();
            this.btnReservedTables = new System.Windows.Forms.Button();
            this.btnBookTable = new System.Windows.Forms.Button();
            this.btnAvailableTable = new System.Windows.Forms.Button();
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
            this.btnclose.Location = new System.Drawing.Point(765, -1);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(35, 35);
            this.btnclose.TabIndex = 7;
            this.btnclose.UseVisualStyleBackColor = false;
            this.btnclose.Click += new System.EventHandler(this.btnclose_Click);
            // 
            // dgvTables
            // 
            this.dgvTables.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTables.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTables.Location = new System.Drawing.Point(-2, 77);
            this.dgvTables.Name = "dgvTables";
            this.dgvTables.ReadOnly = true;
            this.dgvTables.Size = new System.Drawing.Size(482, 316);
            this.dgvTables.TabIndex = 25;
            this.dgvTables.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTables_CellContentClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Black;
            this.label3.Font = new System.Drawing.Font("Tahoma", 24.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Snow;
            this.label3.Location = new System.Drawing.Point(238, -1);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(204, 40);
            this.label3.TabIndex = 27;
            this.label3.Text = "FAST FOOD";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Black;
            this.label2.Font = new System.Drawing.Font("Tahoma", 24.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Snow;
            this.label2.Location = new System.Drawing.Point(0, -1);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(241, 40);
            this.label2.TabIndex = 26;
            this.label2.Text = "RESTAURANT";
            // 
            // btnShowBill
            // 
            this.btnShowBill.BackColor = System.Drawing.Color.Maroon;
            this.btnShowBill.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnShowBill.FlatAppearance.BorderSize = 0;
            this.btnShowBill.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowBill.Font = new System.Drawing.Font("Gadugi", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowBill.ForeColor = System.Drawing.Color.White;
            this.btnShowBill.Location = new System.Drawing.Point(489, 339);
            this.btnShowBill.Name = "btnShowBill";
            this.btnShowBill.Size = new System.Drawing.Size(299, 36);
            this.btnShowBill.TabIndex = 32;
            this.btnShowBill.Text = "استخراج الفاتورة";
            this.btnShowBill.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnShowBill.UseVisualStyleBackColor = false;
            this.btnShowBill.Click += new System.EventHandler(this.btnShowBill_Click);
            // 
            // btnReservedTables
            // 
            this.btnReservedTables.BackColor = System.Drawing.Color.DarkGreen;
            this.btnReservedTables.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReservedTables.FlatAppearance.BorderSize = 0;
            this.btnReservedTables.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReservedTables.Font = new System.Drawing.Font("Gadugi", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReservedTables.ForeColor = System.Drawing.Color.White;
            this.btnReservedTables.Location = new System.Drawing.Point(489, 286);
            this.btnReservedTables.Name = "btnReservedTables";
            this.btnReservedTables.Size = new System.Drawing.Size(299, 36);
            this.btnReservedTables.TabIndex = 31;
            this.btnReservedTables.Text = "الطاولات المحجوزة";
            this.btnReservedTables.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnReservedTables.UseVisualStyleBackColor = false;
            this.btnReservedTables.Click += new System.EventHandler(this.btnReservedTables_Click);
            // 
            // btnBookTable
            // 
            this.btnBookTable.BackColor = System.Drawing.Color.SaddleBrown;
            this.btnBookTable.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBookTable.FlatAppearance.BorderSize = 0;
            this.btnBookTable.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBookTable.Font = new System.Drawing.Font("Gadugi", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBookTable.ForeColor = System.Drawing.Color.White;
            this.btnBookTable.Location = new System.Drawing.Point(489, 232);
            this.btnBookTable.Name = "btnBookTable";
            this.btnBookTable.Size = new System.Drawing.Size(299, 36);
            this.btnBookTable.TabIndex = 30;
            this.btnBookTable.Text = "حجز الطاولة";
            this.btnBookTable.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnBookTable.UseVisualStyleBackColor = false;
            this.btnBookTable.Click += new System.EventHandler(this.btnBookTable_Click);
            // 
            // btnAvailableTable
            // 
            this.btnAvailableTable.BackColor = System.Drawing.Color.Navy;
            this.btnAvailableTable.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAvailableTable.FlatAppearance.BorderSize = 0;
            this.btnAvailableTable.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAvailableTable.Font = new System.Drawing.Font("Gadugi", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAvailableTable.ForeColor = System.Drawing.Color.White;
            this.btnAvailableTable.Location = new System.Drawing.Point(489, 181);
            this.btnAvailableTable.Name = "btnAvailableTable";
            this.btnAvailableTable.Size = new System.Drawing.Size(299, 36);
            this.btnAvailableTable.TabIndex = 33;
            this.btnAvailableTable.Text = "الطاولات المتوفرة";
            this.btnAvailableTable.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAvailableTable.UseVisualStyleBackColor = false;
            this.btnAvailableTable.Click += new System.EventHandler(this.btnAvailableTable_Click);
            // 
            // TableForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(800, 394);
            this.Controls.Add(this.btnAvailableTable);
            this.Controls.Add(this.btnShowBill);
            this.Controls.Add(this.btnReservedTables);
            this.Controls.Add(this.btnBookTable);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvTables);
            this.Controls.Add(this.btnclose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TableForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TableForm";
            this.Load += new System.EventHandler(this.TableForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTables)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnclose;
        private System.Windows.Forms.DataGridView dgvTables;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnShowBill;
        private System.Windows.Forms.Button btnReservedTables;
        private System.Windows.Forms.Button btnBookTable;
        private System.Windows.Forms.Button btnAvailableTable;
    }
}