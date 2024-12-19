using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Restaurant
{
    public partial class CashierForm : Form
    {
        private int userId;
        public CashierForm(int userId)
        {
            InitializeComponent();
            this.userId = userId;
        }
        public CashierForm()
        {
            InitializeComponent();
        }
        private void CashierForm_Load(object sender, EventArgs e)
        {
            try
            {
                Cashier.LoadMeals(cmbMeals);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"حدث خطأ أثناء تحميل النموذج: {ex.Message}");
            }
        }
        private void btnclose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void UpdateTotal()
        {
            Cashier.UpdateTotal(dgvOrderDetails, lblTotal);
        }
        private void ClearForm()
        {
            Cashier.ClearForm(cmbOrderType, dgvOrderDetails, lblTotal);
        }
        private void dgvOrderDetails_CellContentClick(object sender, DataGridViewCellEventArgs e) { }
        private void cmbMeals_SelectedIndexChanged(object sender, EventArgs e) { }
        private void btnRemoveMeal_Click(object sender, EventArgs e)
        {
            Cashier.RemoveSelectedMeal(dgvOrderDetails, UpdateTotal);
        }
        private void btnSaveOrder_Click(object sender, EventArgs e)
        {
            try
            {

                if (cmbOrderType.SelectedItem == null)
                {
                    MessageBox.Show("يرجى اختيار نوع الطلب.");
                    return;
                }

                string orderType = cmbOrderType.SelectedItem.ToString();
                int? tableNumber = null;
                decimal totalPrice = Convert.ToDecimal(lblTotal.Text);

                int orderId = Cashier.SaveOrder(orderType, tableNumber, totalPrice, userId, dgvOrderDetails);

                if (orderId > 0)
                {
                    List<OrderDetail> orderDetails = new List<OrderDetail>();
                    foreach (DataGridViewRow row in dgvOrderDetails.Rows)
                    {
                        if (row.Cells["MealID"].Value == null) continue;

                        orderDetails.Add(new OrderDetail
                        {
                            MealName = row.Cells["MealName"].Value.ToString(),
                            Quantity = Convert.ToInt32(row.Cells["Quantity"].Value),
                            SubTotal = Convert.ToDecimal(row.Cells["SubTotal"].Value)
                        });
                    }

                    BillForm billForm = new BillForm(userId, orderId, orderType, tableNumber, totalPrice, orderDetails)
                    {
                        OrderID = orderId,
                        OrderType = orderType,
                        TableNumber = tableNumber,
                        TotalPrice = totalPrice,
                        OrderDetails = orderDetails
                    };
                    billForm.Show();
                    billForm.Refresh();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("فشل في حفظ الطلب.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"حدث خطأ أثناء حفظ الطلب: {ex.Message}");
            }
        }
        private void numQuantity_ValueChanged(object sender, EventArgs e) { }
        private void txtTableNumber_TextChanged(object sender, EventArgs e) { }
        private void cmbOrderType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbOrderType.SelectedItem?.ToString() == "داخلي")
            {
                btnSaveOrder.Enabled = false;
            }
            else
            {
                btnSaveOrder.Enabled = true;
            }
            Cashier.HandleOrderTypeChange(cmbOrderType, btnSelectTable);
        }
        private void btnAddMeal_Click_1(object sender, EventArgs e)
        {
            Cashier.AddMeal(cmbMeals, numQuantity, dgvOrderDetails, UpdateTotal);
        }
        private void lblTotal_Click(object sender, EventArgs e) { }
        private void btnSelectTable_Click_1(object sender, EventArgs e)
        {
            TableForm table = new TableForm(userId);
            table.OrderType = cmbOrderType.SelectedItem.ToString();
            table.TotalPrice = Convert.ToDecimal(lblTotal.Text);
            table.DgvOrderDetails = dgvOrderDetails;
            table.Show();
            this.Hide();
        }

        private void Logout_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Hide();
        }
    }
}