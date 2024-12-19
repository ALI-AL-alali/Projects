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

namespace Restaurant
{
    public partial class TableInputForm : Form
    {
        public TableInputForm()
        {
            InitializeComponent();
        }
        // الخصائص لاستقبال البيانات
        public int UserID { get; set; }
        public string OrderType { get; set; }
        public int OrderID { get; set; }
        public decimal TotalPrice { get; set; }
        public List<OrderDetail> OrderDetails { get; set; }
        //public int SelectedTableNumber { get; set; }

        public TableInputForm(int userId, string orderType, decimal totalPrice, int selectedTableNumber, List<OrderDetail> orderDetails)
        {
            InitializeComponent();
            UserID = userId;
            OrderType = orderType;
            TotalPrice = totalPrice;
            OrderDetails = orderDetails;
            //SelectedTableNumber = selectedTableNumber;

            // عرض رقم الطاولة في ComboBox
            cmbTableNumbers.Items.Add(selectedTableNumber);
            cmbTableNumbers.SelectedIndex = 0; // القيمة الافتراضية
            cmbTableNumbers.DropDownStyle = ComboBoxStyle.DropDownList;
        }
        static string strconnection = "Data Source=ALOSH;Initial Catalog=Restaurant;Integrated Security=True;";

        private void TableInputForm_Load(object sender, EventArgs e)
        {
            LoadReservedTables();
        }
        private void LoadReservedTables()
        {
            string query = "SELECT TableNumber FROM Tables WHERE Status = 'محجوزة'";
            using (SqlConnection con = new SqlConnection(strconnection))
            {
                SqlDataAdapter adapter = new SqlDataAdapter(query, con);
                DataTable dt = new DataTable();

                try
                {
                    con.Open();
                    adapter.Fill(dt);
                    cmbTableNumbers.DataSource = dt;
                    cmbTableNumbers.DisplayMember = "TableNumber";
                    cmbTableNumbers.ValueMember = "TableNumber";
                    cmbTableNumbers.DropDownStyle = ComboBoxStyle.DropDownList;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("خطأ في تحميل الطاولات: " + ex.Message);
                }
            }
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            // التحقق من اختيار الطاولة
            if (cmbTableNumbers.SelectedItem == null)
            {
                MessageBox.Show("يرجى اختيار رقم الطاولة.");
                return;
            }

            // إعداد رقم الطاولة المختار
            int SelectedTableNumber = Convert.ToInt32(cmbTableNumbers.SelectedValue);
            if(SelectedTableNumber > 0)
            {
            BillForm billForm = new BillForm(UserID, OrderID, OrderType, SelectedTableNumber, TotalPrice, OrderDetails);
            UpdateTableStatusToAvailable(SelectedTableNumber);
            billForm.Show();
            this.Hide();
            }
            else
            {
                MessageBox.Show("لم يتم اختيار طاولة");
            }
        }
        private void UpdateTableStatusToAvailable(int tableNumber)
        {
            string updateQuery = "UPDATE Tables SET Status = 'متوفرة' WHERE TableNumber = @TableNumber";

            using (SqlConnection con = new SqlConnection(strconnection))
            {
                SqlCommand cmd = new SqlCommand(updateQuery, con);
                cmd.Parameters.AddWithValue("@TableNumber", tableNumber);

                try
                {
                    con.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show($"تم تحديث حالة الطاولة رقم {tableNumber} إلى متوفرة.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("خطأ في تحديث حالة الطاولة: " + ex.Message);
                }
            }
        }
    }
}
