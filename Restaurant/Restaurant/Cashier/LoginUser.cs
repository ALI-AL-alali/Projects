using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Restaurant
{
    public static class LoginUser
    {
        static string strconnection = "Data Source=ALOSH;Initial Catalog=Restaurant;Integrated Security=True;";

        public static int? Authenticate(string username, string password)
        {
            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("يرجى إدخال اسم المستخدم وكلمة المرور.");
                return null;
            }

            using (SqlConnection connection = new SqlConnection(strconnection))
            {
                string query = "SELECT UserID FROM Users WHERE Username = @Username AND Password = @Password";
               
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Username", username);
                command.Parameters.AddWithValue("@Password", password);

                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.Read())
                    {
                        int userId = Convert.ToInt32(reader["UserID"]);
                        return userId;
                    }
                    else
                    {
                        MessageBox.Show("اسم المستخدم أو كلمة المرور غير صحيحة.");
                        return null;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"حدث خطأ أثناء تسجيل الدخول: {ex.Message}");
                    return null;
                }
            }
        }
        public static void OpenAppropriateForm(string username, int userId)
        {
            if (username == "admin")
            {
                AdminForm adminForm = new AdminForm(userId);
                adminForm.Show();
            }
            else if (username == "cashier")
            {
                CashierForm cashierForm = new CashierForm(userId);
                cashierForm.Show();
            }
        }
    }
}
