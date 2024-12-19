using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restaurant
{
    internal class Table
    {
        static string strconnection = "Data Source=ALOSH;Initial Catalog=Restaurant;Integrated Security=True;";

        public static void LoadAvailableTables(DataGridView dgvTables)
        {
            using (SqlConnection connection = new SqlConnection(strconnection))
            {
                try
                {
                    connection.Open();

                    string query = "SELECT TableID, TableNumber, Status FROM Tables WHERE Status = 'متوفرة'";
                    SqlCommand command = new SqlCommand(query, connection);

                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dgvTables.DataSource = dt;
                    dgvTables.Columns["TableID"].Visible = false;
                    dgvTables.Columns["TableNumber"].HeaderText = "رقم الطاولة";
                    dgvTables.Columns["Status"].HeaderText = "الحالة";
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"حدث خطأ أثناء تحميل الطاولات: {ex.Message}");
                }
            }
        }
        public static void BookTable(DataGridView dgvTables)
        {
            if (dgvTables.SelectedRows.Count > 0)
            {
                int tableId = Convert.ToInt32(dgvTables.SelectedRows[0].Cells["TableID"].Value);

                string query = "UPDATE Tables SET Status = 'محجوزة' WHERE TableID = @TableID";

                using (SqlConnection con = new SqlConnection(strconnection))
                {
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@TableID", tableId);

                    try
                    {
                        con.Open();
                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("تم حجز الطاولة بنجاح.");
                            
                        }
                        else
                        {
                            MessageBox.Show("حدث خطأ أثناء حجز الطاولة.");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("خطأ: " + ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("يرجى اختيار طاولة من القائمة.");
            }
        }
        public static void ReservedTables(DataGridView dgvTables)
        {
            using (SqlConnection connection = new SqlConnection(strconnection))
            {
                try
                {
                    connection.Open();

                    // جلب الطاولات المحجوزة
                    string query = "SELECT TableID, TableNumber, Status FROM Tables WHERE Status = 'محجوزة'";
                    SqlCommand command = new SqlCommand(query, connection);

                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dgvTables.DataSource = dt;
                    dgvTables.Columns["TableID"].Visible = false;
                    dgvTables.Columns["TableNumber"].HeaderText = "رقم الطاولة";
                    dgvTables.Columns["Status"].HeaderText = "الحالة";
                    if (dt.Rows.Count == 0)
                    {
                        MessageBox.Show("لا توجد طاولات محجوزة حاليًا.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"حدث خطأ أثناء عرض الطاولات المحجوزة: {ex.Message}");
                }
            }
        }


    }
}
