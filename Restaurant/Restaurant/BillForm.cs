using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using System.Drawing.Printing;

namespace Restaurant
{
    public partial class BillForm : Form
    {
        private int userId;

        public int OrderID { get; set; }
        public string OrderType { get; set; }
        public int? TableNumber { get; set; }
        public int? TableID { get; set; }
        public decimal TotalPrice { get; set; }
        public List<OrderDetail> OrderDetails { get; set; }
        public BillForm(int userId, int orderId, string orderType, int? tableNumber, decimal totalPrice, List<OrderDetail> orderDetails)
        {
            InitializeComponent();
            this.userId = userId;
            this.OrderID = orderId;
            this.OrderType = orderType;
            this.TableNumber = tableNumber;
            this.TotalPrice = totalPrice;
            this.OrderDetails = orderDetails;
        }
        public BillForm()
        {
            InitializeComponent();
        }
        public BillForm(int userId)
        {
            this.userId = userId;
        }

        private void BillForm_Load_1(object sender, EventArgs e)
        {

            if (OrderID > 0)
            {
                try
                {
                    Bill.LoadBillData(
                        OrderID,
                        OrderType,
                        TableNumber,
                        TotalPrice,
                        OrderDetails,
                        lblOrderID,
                        lblOrderType,
                        lblTableNumber,
                        lblTotalPrice,
                        dgvOrders);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"حدث خطأ أثناء تحميل بيانات الفاتورة: {ex.Message}");
                }
            }
            else
            {
                MessageBox.Show("رقم الطلب غير موجود. لا يمكن تحميل البيانات.");
            }
            
        }
        private void btnclose_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnBackToCashier_Click(object sender, EventArgs e)
        {
            CashierForm cashierForm = new CashierForm(userId);
            cashierForm.Show();
            this.Close();
        }

        private void dgvOrders_CellContentClick(object sender, DataGridViewCellEventArgs e) { }
        private void lblOrderID_Click(object sender, EventArgs e) { }
        private void lblOrderType_Click(object sender, EventArgs e) { }
        private void lblTableNumber_Click(object sender, EventArgs e) { }
        private void lblTotalPrice_Click(object sender, EventArgs e) { }
        private void btnPrintBill_Click_1(object sender, EventArgs e)
        {
            PrintDocument printDocument = new PrintDocument();
            printDocument.PrintPage += (s, ev) =>
            {
                string invoiceDetails = $"رقم الطلب: {OrderID}\n" +
                                        $"نوع الطلب: {OrderType}\n" +
                                        $"رقم الطاولة: {TableNumber}\n" +
                                        $"المجموع الكلي: {TotalPrice:C2}\n\n" +
                                        "تفاصيل الطلب:\n";

                foreach (var detail in OrderDetails)
                {
                    invoiceDetails += $"اسم الوجبة: {detail.MealName}, " +
                                      $"الكمية: {detail.Quantity}, " +
                                      $"الإجمالي: {detail.SubTotal:C2}\n";
                }

                ev.Graphics.DrawString(invoiceDetails, new Font("Arial", 12), Brushes.Black, 10, 10);
            };

            PrintDialog printDialog = new PrintDialog
            {
                Document = printDocument
            };

            if (printDialog.ShowDialog() == DialogResult.OK)
            {
                printDocument.Print();
            }


            //لطياعة الفورم كاملة 
            //PrintDocument printDocument = new PrintDocument();
            //printDocument.PrintPage += PrintDocument_PrintPage;

            //// عرض مربع حوار الطباعة
            //PrintDialog printDialog = new PrintDialog
            //{
            //    Document = printDocument
            //};

            //if (printDialog.ShowDialog() == DialogResult.OK)
            //{
            //    printDocument.Print();
            //}
        }

        //private void PrintDocument_PrintPage(object sender, PrintPageEventArgs e)
        //{
        //    // إنشاء صورة للواجهة
        //    Bitmap bitmap = new Bitmap(this.Width, this.Height);
        //    this.DrawToBitmap(bitmap, new Rectangle(0, 0, this.Width, this.Height));

        //    // رسم الصورة على الصفحة للطباعة
        //    e.Graphics.DrawImage(bitmap, 0, 0);
        //}
    }
}
