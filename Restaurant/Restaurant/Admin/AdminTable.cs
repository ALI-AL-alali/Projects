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

    internal class AdminTable
    {
        static string connectionString = "Data Source=ALOSH;Initial Catalog=Restaurant;Integrated Security=True;";
        public static void LoadTablesData(DataGridView dgvTables)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM Tables";
                SqlDataAdapter adapter = new SqlDataAdapter(query, con);
                DataTable tableData = new DataTable();

                try
                {
                    con.Open();
                    adapter.Fill(tableData);
                    dgvTables.DataSource = tableData;
                    dgvTables.Columns["TableID"].Visible = false;
                    dgvTables.Columns["TableNumber"].HeaderText = "رقم الطاولة";
                    dgvTables.Columns["Status"].HeaderText = "الحالة";

                }
                catch (Exception ex)
                {
                    MessageBox.Show("خطأ أثناء تحميل البيانات: " + ex.Message);
                }
            }
        }

        public static void AddTable(TextBox txtTableNumber , ComboBox cmbTableStatus , DataGridView dgvTables)
        {
            if (string.IsNullOrWhiteSpace(txtTableNumber.Text) || string.IsNullOrWhiteSpace(cmbTableStatus.Text))
            {
                MessageBox.Show("يرجى إدخال جميع البيانات!");
                return;
            }

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO Tables (TableNumber, Status) VALUES (@TableNumber, @Status)";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@TableNumber", txtTableNumber.Text);
                cmd.Parameters.AddWithValue("@Status", cmbTableStatus.Text);

                try
                {
                    con.Open();
                    cmd.ExecuteNonQuery();
                    LoadTablesData(dgvTables);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("خطأ أثناء إضافة الطاولة: " + ex.Message);
                }
            }
        }
        public static void EditTable(TextBox txtTableNumber, ComboBox cmbTableStatus, DataGridView dgvTables)
        {
            if (dgvTables.CurrentRow == null)
            {
                MessageBox.Show("يرجى تحديد الطاولة المراد تعديلها!");
                return;
            }

            int tableID = Convert.ToInt32(dgvTables.CurrentRow.Cells["TableID"].Value);

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = "UPDATE Tables SET TableNumber = @TableNumber, Status = @Status WHERE TableID = @TableID";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@TableID", tableID);
                cmd.Parameters.AddWithValue("@TableNumber", txtTableNumber.Text);
                cmd.Parameters.AddWithValue("@Status", cmbTableStatus.Text);

                try
                {
                    con.Open();
                    cmd.ExecuteNonQuery();
                    LoadTablesData(dgvTables);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("خطأ أثناء تعديل الطاولة: " + ex.Message);
                }
            }
        }
        public static void DeleteTable(DataGridView dgvTables)
        {
            if (dgvTables.CurrentRow == null)
            {
                MessageBox.Show("يرجى تحديد الطاولة المراد حذفها!");
                return;
            }

            int tableID = Convert.ToInt32(dgvTables.CurrentRow.Cells["TableID"].Value);

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = "DELETE FROM Tables WHERE TableID = @TableID";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@TableID", tableID);

                try
                {
                    con.Open();
                    cmd.ExecuteNonQuery();
                    LoadTablesData(dgvTables);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("خطأ أثناء حذف الطاولة: " + ex.Message);
                }
            }
        }


    }
}
