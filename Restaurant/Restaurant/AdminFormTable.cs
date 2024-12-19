using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restaurant
{
    public partial class AdminFormTable : Form
    {
        private int userId;

        public AdminFormTable(int userId)
        {
            InitializeComponent();
            this.userId = userId;
        }
        public AdminFormTable()
        {
            InitializeComponent();
        }

        private void AdminFormTable_Load(object sender, EventArgs e)
        {
            AdminTable.LoadTablesData(dgvTables);
        }

        private void btnAddTable_Click(object sender, EventArgs e)
        {
            AdminTable.AddTable(txtTableNumber,cmbTableStatus,dgvTables);
        }

        private void btnEditTable_Click(object sender, EventArgs e)
        {
            AdminTable.EditTable(txtTableNumber, cmbTableStatus, dgvTables);
        }

        private void btnRemoveTable_Click(object sender, EventArgs e)
        {
            AdminTable.DeleteTable(dgvTables);
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Logout_Click(object sender, EventArgs e)
        {
            AdminForm adminForm = new AdminForm(userId);
            adminForm.Show();
            this.Hide();
        }
    }
}
