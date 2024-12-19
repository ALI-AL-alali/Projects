namespace Restaurant
{
    partial class TableInputForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TableInputForm));
            this.cmbTableNumbers = new System.Windows.Forms.ComboBox();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmbTableNumbers
            // 
            this.cmbTableNumbers.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTableNumbers.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTableNumbers.FormattingEnabled = true;
            this.cmbTableNumbers.Location = new System.Drawing.Point(40, 70);
            this.cmbTableNumbers.Name = "cmbTableNumbers";
            this.cmbTableNumbers.Size = new System.Drawing.Size(130, 27);
            this.cmbTableNumbers.TabIndex = 8;
            // 
            // btnConfirm
            // 
            this.btnConfirm.BackColor = System.Drawing.Color.DarkGreen;
            this.btnConfirm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConfirm.FlatAppearance.BorderSize = 0;
            this.btnConfirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirm.Font = new System.Drawing.Font("Gadugi", 15.75F, System.Drawing.FontStyle.Bold);
            this.btnConfirm.ForeColor = System.Drawing.Color.White;
            this.btnConfirm.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnConfirm.Location = new System.Drawing.Point(40, 117);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(130, 36);
            this.btnConfirm.TabIndex = 40;
            this.btnConfirm.Text = "تاكيد";
            this.btnConfirm.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnConfirm.UseVisualStyleBackColor = false;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 24);
            this.label1.TabIndex = 41;
            this.label1.Text = "اختر رقم الطاولة ";
            // 
            // TableInputForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(206, 165);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.cmbTableNumbers);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TableInputForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.Load += new System.EventHandler(this.TableInputForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbTableNumbers;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Label label1;
    }
}