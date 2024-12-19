namespace Restaurant
{
    partial class AdminFormMeals
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminFormMeals));
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dgvMeals = new System.Windows.Forms.DataGridView();
            this.txtNameMeal = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnRemoveMeal = new System.Windows.Forms.Button();
            this.btnEditMeal = new System.Windows.Forms.Button();
            this.btnAddMeal = new System.Windows.Forms.Button();
            this.btnclose = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPriceMeal = new System.Windows.Forms.TextBox();
            this.txtDescriptionMeal = new System.Windows.Forms.TextBox();
            this.Logout = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMeals)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Black;
            this.label3.Font = new System.Drawing.Font("Tahoma", 24.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(243, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(204, 40);
            this.label3.TabIndex = 39;
            this.label3.Text = "FAST FOOD";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Black;
            this.label4.Font = new System.Drawing.Font("Tahoma", 24.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(5, 3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(241, 40);
            this.label4.TabIndex = 38;
            this.label4.Text = "RESTAURANT";
            // 
            // dgvMeals
            // 
            this.dgvMeals.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMeals.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMeals.Location = new System.Drawing.Point(1, 62);
            this.dgvMeals.Name = "dgvMeals";
            this.dgvMeals.ReadOnly = true;
            this.dgvMeals.Size = new System.Drawing.Size(455, 310);
            this.dgvMeals.TabIndex = 37;
            // 
            // txtNameMeal
            // 
            this.txtNameMeal.Font = new System.Drawing.Font("Tahoma", 12F);
            this.txtNameMeal.Location = new System.Drawing.Point(509, 62);
            this.txtNameMeal.Name = "txtNameMeal";
            this.txtNameMeal.Size = new System.Drawing.Size(186, 27);
            this.txtNameMeal.TabIndex = 36;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(708, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 24);
            this.label2.TabIndex = 34;
            this.label2.Text = "اسم الوجبة";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(750, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 24);
            this.label1.TabIndex = 33;
            this.label1.Text = "الوصف";
            // 
            // btnRemoveMeal
            // 
            this.btnRemoveMeal.BackColor = System.Drawing.Color.Maroon;
            this.btnRemoveMeal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRemoveMeal.FlatAppearance.BorderSize = 0;
            this.btnRemoveMeal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoveMeal.Font = new System.Drawing.Font("Gadugi", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveMeal.ForeColor = System.Drawing.Color.White;
            this.btnRemoveMeal.Location = new System.Drawing.Point(509, 320);
            this.btnRemoveMeal.Name = "btnRemoveMeal";
            this.btnRemoveMeal.Size = new System.Drawing.Size(295, 36);
            this.btnRemoveMeal.TabIndex = 32;
            this.btnRemoveMeal.Text = "حذف الوجبة";
            this.btnRemoveMeal.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnRemoveMeal.UseVisualStyleBackColor = false;
            this.btnRemoveMeal.Click += new System.EventHandler(this.btnRemoveMeal_Click);
            // 
            // btnEditMeal
            // 
            this.btnEditMeal.BackColor = System.Drawing.Color.DarkGreen;
            this.btnEditMeal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditMeal.FlatAppearance.BorderSize = 0;
            this.btnEditMeal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditMeal.Font = new System.Drawing.Font("Gadugi", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditMeal.ForeColor = System.Drawing.Color.White;
            this.btnEditMeal.Location = new System.Drawing.Point(509, 266);
            this.btnEditMeal.Name = "btnEditMeal";
            this.btnEditMeal.Size = new System.Drawing.Size(295, 36);
            this.btnEditMeal.TabIndex = 31;
            this.btnEditMeal.Text = "تعديل الوجبة";
            this.btnEditMeal.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnEditMeal.UseVisualStyleBackColor = false;
            this.btnEditMeal.Click += new System.EventHandler(this.btnEditMeal_Click);
            // 
            // btnAddMeal
            // 
            this.btnAddMeal.BackColor = System.Drawing.Color.Navy;
            this.btnAddMeal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddMeal.FlatAppearance.BorderSize = 0;
            this.btnAddMeal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddMeal.Font = new System.Drawing.Font("Gadugi", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddMeal.ForeColor = System.Drawing.Color.White;
            this.btnAddMeal.Location = new System.Drawing.Point(509, 214);
            this.btnAddMeal.Name = "btnAddMeal";
            this.btnAddMeal.Size = new System.Drawing.Size(295, 36);
            this.btnAddMeal.TabIndex = 30;
            this.btnAddMeal.Text = "إضافة الوجبة";
            this.btnAddMeal.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAddMeal.UseVisualStyleBackColor = false;
            this.btnAddMeal.Click += new System.EventHandler(this.btnAddMeal_Click);
            // 
            // btnclose
            // 
            this.btnclose.BackColor = System.Drawing.Color.Transparent;
            this.btnclose.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnclose.BackgroundImage")));
            this.btnclose.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnclose.ForeColor = System.Drawing.Color.Transparent;
            this.btnclose.Image = ((System.Drawing.Image)(resources.GetObject("btnclose.Image")));
            this.btnclose.Location = new System.Drawing.Point(792, 3);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(35, 35);
            this.btnclose.TabIndex = 29;
            this.btnclose.UseVisualStyleBackColor = false;
            this.btnclose.Click += new System.EventHandler(this.btnclose_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Black;
            this.label5.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(750, 157);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 24);
            this.label5.TabIndex = 40;
            this.label5.Text = "السعر";
            // 
            // txtPriceMeal
            // 
            this.txtPriceMeal.Font = new System.Drawing.Font("Tahoma", 12F);
            this.txtPriceMeal.Location = new System.Drawing.Point(509, 158);
            this.txtPriceMeal.Name = "txtPriceMeal";
            this.txtPriceMeal.Size = new System.Drawing.Size(186, 27);
            this.txtPriceMeal.TabIndex = 41;
            // 
            // txtDescriptionMeal
            // 
            this.txtDescriptionMeal.Font = new System.Drawing.Font("Tahoma", 12F);
            this.txtDescriptionMeal.Location = new System.Drawing.Point(509, 110);
            this.txtDescriptionMeal.Name = "txtDescriptionMeal";
            this.txtDescriptionMeal.Size = new System.Drawing.Size(186, 27);
            this.txtDescriptionMeal.TabIndex = 42;
            // 
            // Logout
            // 
            this.Logout.BackColor = System.Drawing.Color.Transparent;
            this.Logout.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Logout.BackgroundImage")));
            this.Logout.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Logout.ForeColor = System.Drawing.Color.Transparent;
            this.Logout.Image = ((System.Drawing.Image)(resources.GetObject("Logout.Image")));
            this.Logout.Location = new System.Drawing.Point(754, 3);
            this.Logout.Name = "Logout";
            this.Logout.Size = new System.Drawing.Size(35, 35);
            this.Logout.TabIndex = 43;
            this.Logout.UseVisualStyleBackColor = false;
            this.Logout.Click += new System.EventHandler(this.Logout_Click);
            // 
            // AdminFormMeals
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(830, 375);
            this.Controls.Add(this.Logout);
            this.Controls.Add(this.txtDescriptionMeal);
            this.Controls.Add(this.txtPriceMeal);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dgvMeals);
            this.Controls.Add(this.txtNameMeal);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnRemoveMeal);
            this.Controls.Add(this.btnEditMeal);
            this.Controls.Add(this.btnAddMeal);
            this.Controls.Add(this.btnclose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AdminFormMeals";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminFormMeal";
            this.Load += new System.EventHandler(this.AdminFormMeals_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMeals)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgvMeals;
        private System.Windows.Forms.TextBox txtNameMeal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnRemoveMeal;
        private System.Windows.Forms.Button btnEditMeal;
        private System.Windows.Forms.Button btnAddMeal;
        private System.Windows.Forms.Button btnclose;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtPriceMeal;
        private System.Windows.Forms.TextBox txtDescriptionMeal;
        private System.Windows.Forms.Button Logout;
    }
}