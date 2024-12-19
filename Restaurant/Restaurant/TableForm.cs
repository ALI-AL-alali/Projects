using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace Restaurant
{
    public partial class TableForm : Form
    {
        static string strconnection = "Data Source=ALOSH;Initial Catalog=Restaurant;Integrated Security=True;";

        private int userId;
        public TableForm(int userId)
        {
            InitializeComponent();
            this.userId = userId;
        }
        public string OrderType { get; set; }
        public decimal TotalPrice { get; set; }
        public DataGridView DgvOrderDetails { get; set; }
        public int SelectedTableNumber { get; set; }
        public TableForm()
        {
            InitializeComponent();
        }

        private void TableForm_Load(object sender, EventArgs e)
        {

        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void dgvTables_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnAvailableTable_Click(object sender, EventArgs e)
        {
            Table.LoadAvailableTables(dgvTables);
        }

        private void btnBookTable_Click(object sender, EventArgs e)
        {
            Table.BookTable(dgvTables);
            btnAvailableTable.PerformClick();
        }

        private void btnReservedTables_Click(object sender, EventArgs e)
        {
            Table.ReservedTables(dgvTables);
        }

        private void btnShowBill_Click(object sender, EventArgs e)
        {

            int orderId = Cashier.SaveOrder(OrderType, SelectedTableNumber, TotalPrice, userId, DgvOrderDetails);
            if (orderId <= 0)
            {
                MessageBox.Show("فشل في حفظ الطلب.");
                return;
            }
            List<OrderDetail> orderDetails = new List<OrderDetail>();
            foreach (DataGridViewRow row in DgvOrderDetails.Rows)
            {
                if (row.Cells["MealID"].Value == null) continue;

                orderDetails.Add(new OrderDetail
                {
                    MealName = row.Cells["MealName"].Value.ToString(),
                    Quantity = Convert.ToInt32(row.Cells["Quantity"].Value),
                    SubTotal = Convert.ToDecimal(row.Cells["SubTotal"].Value)
                });
            }
            if (orderId > 0)
            {
                TableInputForm form = new TableInputForm();
                form.UserID = userId;
                form.OrderID = orderId;
                form.OrderType = OrderType;
                form.TotalPrice = TotalPrice;
                form.OrderDetails = orderDetails;
                form.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("حدث خطأ أثناء حفظ الطلب.");
            }

            this.Hide();

            
        }

        // وظيفة للتحقق من حالة الطاولة
        private int? GetReservedTableId(int tableNumber)
        {
            string queryCheck = "SELECT TableID FROM Tables WHERE TableNumber = @TableNumber AND Status = 'محجوزة'";

            using (SqlConnection con = new SqlConnection(strconnection))
            {
                SqlCommand cmd = new SqlCommand(queryCheck, con);
                cmd.Parameters.AddWithValue("@TableNumber", tableNumber);

                try
                {
                    con.Open();
                    object result = cmd.ExecuteScalar();

                    if (result != null)
                    {
                        return Convert.ToInt32(result);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("خطأ أثناء التحقق من حالة الطاولة: " + ex.Message);
                }
            }

            return null;
        }

        private List<string> GetAvailableTableNumbers()
        {
            List<string> tableNumbers = new List<string>();
            string query = "SELECT TableNumber FROM Tables WHERE Status = 'محجوزة'";

            using (SqlConnection connection = new SqlConnection(strconnection))
            {
                SqlCommand cmd = new SqlCommand(query, connection);

                try
                {
                    connection.Open();
                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        tableNumbers.Add(reader["TableNumber"].ToString());
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"خطأ أثناء جلب أرقام الطاولات: {ex.Message}");
                }
            }

            return tableNumbers;
        }

    }
}
