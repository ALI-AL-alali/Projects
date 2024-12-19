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
    public partial class AdminForm : Form
    {
        private int userId;

        public AdminForm(int userId)
        {
            InitializeComponent();
            this.userId = userId;
        }
        public AdminForm()
        {
            InitializeComponent();
        }

        private void btnShowMeal_Click(object sender, EventArgs e)
        {
            AdminFormMeals adminFormMeals = new AdminFormMeals(userId);
            adminFormMeals.Show();
            this.Hide();
        }

        private void btnShowTable_Click(object sender, EventArgs e)
        {
            AdminFormTable adminFormTable = new AdminFormTable(userId);
            adminFormTable.Show();
            this.Hide();
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Logout_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Hide();
        }
    }
}
