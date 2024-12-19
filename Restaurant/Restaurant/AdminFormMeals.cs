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
    public partial class AdminFormMeals : Form
    {
        private int userId;

        public AdminFormMeals(int userId)
        {
            InitializeComponent();
            this.userId = userId;
        }
        public AdminFormMeals()
        {
            InitializeComponent();
        }

        private void AdminFormMeals_Load(object sender, EventArgs e)
        {
            AdminMeal.LoadMeals(dgvMeals);
        }

        private void btnAddMeal_Click(object sender, EventArgs e)
        {
            string mealName = txtNameMeal.Text.Trim();
            string mealDescription = txtDescriptionMeal.Text.Trim();
            string mealPrice = txtPriceMeal.Text.Trim();

            AdminMeal.AddMeal(mealName, mealDescription, mealPrice, dgvMeals);
        }

        private void btnEditMeal_Click(object sender, EventArgs e)
        {
            if (dgvMeals.SelectedRows.Count > 0)
            {
                int mealId = Convert.ToInt32(dgvMeals.SelectedRows[0].Cells["MealID"].Value);

                string mealName = txtNameMeal.Text.Trim();
                string mealDescription = txtDescriptionMeal.Text.Trim();
                string mealPrice = txtPriceMeal.Text.Trim();

                AdminMeal.EditMeal(mealId, mealName, mealDescription, mealPrice, dgvMeals);
            }
            else
            {
                MessageBox.Show("يرجى اختيار وجبة لتعديلها.");
            }
        }

        private void btnRemoveMeal_Click(object sender, EventArgs e)
        {
            if (dgvMeals.SelectedRows.Count > 0)
            {
                int mealId = Convert.ToInt32(dgvMeals.SelectedRows[0].Cells["MealID"].Value);

                AdminMeal.DeleteMeal(mealId, dgvMeals);
            }
            else
            {
                MessageBox.Show("يرجى اختيار وجبة لحذفها.");
            }
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
