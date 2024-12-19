using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restaurant
{
    internal class Cashier
    {
        static string strconnection = "Data Source=ALOSH;Initial Catalog=Restaurant;Integrated Security=True";

        public static void UpdateTotal(DataGridView dgvOrderDetails, Label lblTotal)
        {
            try
            {
                decimal total = 0;

                foreach (DataGridViewRow row in dgvOrderDetails.Rows)
                {
                    if (row.Cells["SubTotal"].Value != null)
                    {
                        total += Convert.ToDecimal(row.Cells["SubTotal"].Value);
                    }
                }

                lblTotal.Text = total.ToString("F2");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"حدث خطأ أثناء تحديث الإجمالي:\n {ex.Message}");
            }
        }
        public static void ClearForm(ComboBox cmbOrderType, DataGridView dgvOrderDetails, Label lblTotal)
        {
            try
            {
                cmbOrderType.SelectedIndex = -1;
                dgvOrderDetails.Rows.Clear();
                lblTotal.Text = "0.00";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"حدث خطأ أثناء تفريغ النموذج:\n {ex.Message}");
            }
        }
        public static void LoadMeals(ComboBox comboBox)
        {
            using (SqlConnection connection = new SqlConnection(strconnection))
            {
                string query = "SELECT MealID, Name, Price FROM Meals";
                SqlCommand command = new SqlCommand(query, connection);
                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    List<Meal> meals = new List<Meal>();
                    while (reader.Read())
                    {
                        meals.Add(new Meal
                        {
                            MealID = Convert.ToInt32(reader["MealID"]),
                            Name = reader["Name"].ToString(),
                            Price = Convert.ToDecimal(reader["Price"])
                        });
                    }

                    comboBox.DataSource = meals;
                    comboBox.DisplayMember = "Name"; 
                    comboBox.ValueMember = "MealID"; 
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"خطأ أثناء تحميل الوجبات: {ex.Message}");
                }
            }
        }
        public static void AddMeal(
    ComboBox cmbMeals,
    NumericUpDown numQuantity,
    DataGridView dgvOrderDetails,
    Action updateTotal)
        {
            try
            {
                if (cmbMeals.SelectedItem == null || numQuantity.Value <= 0)
                {
                    MessageBox.Show("يرجى اختيار وجبة وتحديد الكمية.");
                    return;
                }

                var selectedMeal = (dynamic)cmbMeals.SelectedItem;
                int mealId = selectedMeal.MealID;
                string mealName = selectedMeal.Name;
                decimal price = selectedMeal.Price;
                int quantity = (int)numQuantity.Value;
                decimal subtotal = price * quantity;

                dgvOrderDetails.Rows.Add(mealId, mealName, price, quantity, subtotal);

                updateTotal?.Invoke();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"حدث خطأ أثناء إضافة الوجبة:\n {ex.Message}");
            }
        }
        public static void RemoveSelectedMeal(DataGridView dgvOrderDetails, Action updateTotal)
        {
            try
            {
                if (dgvOrderDetails.SelectedRows.Count > 0)
                {
                    dgvOrderDetails.Rows.RemoveAt(dgvOrderDetails.SelectedRows[0].Index);

                    updateTotal?.Invoke();
                }
                else
                {
                    MessageBox.Show("يرجى تحديد الوجبة المراد حذفها.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"حدث خطأ أثناء حذف الطلب:\n {ex.Message}");
            }
        }
        public static int SaveOrder(string orderType, int? tableNumber, decimal totalPrice, int userId, DataGridView dgvOrderDetails)
        {
            int orderId = -1;

            using (SqlConnection connection = new SqlConnection(strconnection))
            {
                try
                {
                    connection.Open();

                    string insertOrderQuery = @"
                INSERT INTO Orders (UserID, OrderType, TableNumber, TotalPrice)
                OUTPUT INSERTED.OrderID
                VALUES (@UserID, @OrderType, @TableNumber, @TotalPrice)";
                    SqlCommand orderCommand = new SqlCommand(insertOrderQuery, connection);
                    orderCommand.Parameters.AddWithValue("@UserID", userId);
                    orderCommand.Parameters.AddWithValue("@OrderType", orderType);
                    orderCommand.Parameters.AddWithValue("@TableNumber", (object)tableNumber ?? DBNull.Value);
                    orderCommand.Parameters.AddWithValue("@TotalPrice", totalPrice);

                    orderId = Convert.ToInt32(orderCommand.ExecuteScalar());

                    foreach (DataGridViewRow row in dgvOrderDetails.Rows)
                    {
                        if (row.Cells["MealID"].Value == null || row.Cells["Quantity"].Value == null || row.Cells["SubTotal"].Value == null)
                        {
                            continue; 
                        }

                        string insertDetailQuery = @"
                    INSERT INTO OrderDetails (OrderID, MealID, Quantity, SubTotal)
                    VALUES (@OrderID, @MealID, @Quantity, @SubTotal)";
                        SqlCommand detailCommand = new SqlCommand(insertDetailQuery, connection);
                        detailCommand.Parameters.AddWithValue("@OrderID", orderId);
                        detailCommand.Parameters.AddWithValue("@MealID", row.Cells["MealID"].Value);
                        detailCommand.Parameters.AddWithValue("@Quantity", row.Cells["Quantity"].Value);
                        detailCommand.Parameters.AddWithValue("@SubTotal", row.Cells["SubTotal"].Value);

                        detailCommand.ExecuteNonQuery();
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show($"حدث خطأ أثناء حفظ الطلب: {ex.Message}");
                }
            }
            return orderId;
        }


        public static void HandleOrderTypeChange(ComboBox cmbOrderType, Button btnSelectTable)
        {
            if (cmbOrderType.SelectedItem?.ToString() == "داخلي")
            {
                btnSelectTable.Enabled = true; 
            }
            else
            {
                btnSelectTable.Enabled = false;
            }
        }
    }
}