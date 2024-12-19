using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Restaurant
{
    public static class Bill
    {
        static string strconnection = "Data Source=ALOSH;Initial Catalog=Restaurant;Integrated Security=True;";

        public static void LoadBillData(
        int orderId,
        string orderType,
        int? tableNumber,
        decimal totalPrice,
        List<OrderDetail> orderDetails,
        Label lblOrderID,
        Label lblOrderType,
        Label lblTableNumber,
        Label lblTotalPrice,
        DataGridView dgvOrders)
        {
            using (SqlConnection connection = new SqlConnection(strconnection))
            {
                try
                {
                    connection.Open();

                    string orderQuery = @"
                SELECT OrderID, OrderType, TableNumber, TotalPrice
                FROM Orders
                WHERE OrderID = @OrderID";

                    SqlCommand orderCommand = new SqlCommand(orderQuery, connection);
                    orderCommand.Parameters.AddWithValue("@OrderID", orderId);

                    SqlDataReader reader = orderCommand.ExecuteReader();
                    if (reader.Read())
                    {
                        lblOrderID.Text = reader["OrderID"].ToString();
                        lblOrderType.Text = reader["OrderType"].ToString();
                    lblTableNumber.Text = tableNumber?.ToString() ?? "لا يوجد";
                        lblTotalPrice.Text = $"{Convert.ToDecimal(reader["TotalPrice"]):C2}";
                    }
                    else
                    {
                        MessageBox.Show("لم يتم العثور على بيانات الطلب.");
                        return;
                    }
                    reader.Close();

                    string detailsQuery = @"
                SELECT m.Name AS MealName, d.Quantity, d.SubTotal
                FROM OrderDetails d
                JOIN Meals m ON d.MealID = m.MealID
                WHERE d.OrderID = @OrderID";

                    SqlCommand detailsCommand = new SqlCommand(detailsQuery, connection);
                    detailsCommand.Parameters.AddWithValue("@OrderID", orderId);

                    SqlDataAdapter adapter = new SqlDataAdapter(detailsCommand);
                    DataTable detailsTable = new DataTable();
                    adapter.Fill(detailsTable);

                    dgvOrders.DataSource = detailsTable;

                    dgvOrders.Columns["MealName"].HeaderText = "اسم الوجبة";
                    dgvOrders.Columns["Quantity"].HeaderText = "الكمية";
                    dgvOrders.Columns["SubTotal"].HeaderText = "السعر الإجمالي";
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"حدث خطأ أثناء تحميل بيانات الفاتورة: {ex.Message}");
                }
            }
        }

    }
}
