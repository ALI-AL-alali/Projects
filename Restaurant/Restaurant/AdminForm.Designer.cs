namespace Restaurant
{
    partial class AdminForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminForm));
            this.btnShowMeal = new System.Windows.Forms.Button();
            this.btnShowTable = new System.Windows.Forms.Button();
            this.Logout = new System.Windows.Forms.Button();
            this.btnclose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnShowMeal
            // 
            this.btnShowMeal.BackColor = System.Drawing.Color.Navy;
            this.btnShowMeal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnShowMeal.FlatAppearance.BorderSize = 0;
            this.btnShowMeal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowMeal.Font = new System.Drawing.Font("Gadugi", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowMeal.ForeColor = System.Drawing.Color.White;
            this.btnShowMeal.Location = new System.Drawing.Point(12, 50);
            this.btnShowMeal.Name = "btnShowMeal";
            this.btnShowMeal.Size = new System.Drawing.Size(299, 106);
            this.btnShowMeal.TabIndex = 39;
            this.btnShowMeal.Text = "واجهة إدارة الاطعمة";
            this.btnShowMeal.UseVisualStyleBackColor = false;
            this.btnShowMeal.Click += new System.EventHandler(this.btnShowMeal_Click);
            // 
            // btnShowTable
            // 
            this.btnShowTable.BackColor = System.Drawing.Color.DarkGreen;
            this.btnShowTable.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnShowTable.FlatAppearance.BorderSize = 0;
            this.btnShowTable.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowTable.Font = new System.Drawing.Font("Gadugi", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowTable.ForeColor = System.Drawing.Color.White;
            this.btnShowTable.Location = new System.Drawing.Point(12, 162);
            this.btnShowTable.Name = "btnShowTable";
            this.btnShowTable.Size = new System.Drawing.Size(299, 106);
            this.btnShowTable.TabIndex = 38;
            this.btnShowTable.Text = "واجهة إدارة الطاولات";
            this.btnShowTable.UseVisualStyleBackColor = false;
            this.btnShowTable.Click += new System.EventHandler(this.btnShowTable_Click);
            // 
            // Logout
            // 
            this.Logout.BackColor = System.Drawing.Color.Transparent;
            this.Logout.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Logout.BackgroundImage")));
            this.Logout.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Logout.ForeColor = System.Drawing.Color.Transparent;
            this.Logout.Location = new System.Drawing.Point(252, 0);
            this.Logout.Name = "Logout";
            this.Logout.Size = new System.Drawing.Size(35, 35);
            this.Logout.TabIndex = 41;
            this.Logout.UseVisualStyleBackColor = false;
            this.Logout.Click += new System.EventHandler(this.Logout_Click);
            // 
            // btnclose
            // 
            this.btnclose.BackColor = System.Drawing.Color.Transparent;
            this.btnclose.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnclose.BackgroundImage")));
            this.btnclose.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnclose.ForeColor = System.Drawing.Color.Transparent;
            this.btnclose.Image = ((System.Drawing.Image)(resources.GetObject("btnclose.Image")));
            this.btnclose.Location = new System.Drawing.Point(288, 0);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(35, 35);
            this.btnclose.TabIndex = 40;
            this.btnclose.UseVisualStyleBackColor = false;
            this.btnclose.Click += new System.EventHandler(this.btnclose_Click);
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(323, 275);
            this.Controls.Add(this.Logout);
            this.Controls.Add(this.btnclose);
            this.Controls.Add(this.btnShowMeal);
            this.Controls.Add(this.btnShowTable);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AdminForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnShowMeal;
        private System.Windows.Forms.Button btnShowTable;
        private System.Windows.Forms.Button Logout;
        private System.Windows.Forms.Button btnclose;
    }
}