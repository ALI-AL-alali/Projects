using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

public class AdminMeal
{
    private static string strconnection = "Data Source=ALOSH;Initial Catalog=Restaurant;Integrated Security=True;";

    public static void LoadMeals(DataGridView dgvMeals)
    {
        using (SqlConnection connection = new SqlConnection(strconnection))
        {
            try
            {
                connection.Open();
                string query = "SELECT MealID, Name, Description, Price FROM Meals";
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable mealsTable = new DataTable();
                adapter.Fill(mealsTable);

                dgvMeals.DataSource = mealsTable;

                dgvMeals.Columns["MealID"].Visible = false;
                dgvMeals.Columns["Name"].HeaderText = "اسم الوجبة";
                dgvMeals.Columns["Description"].HeaderText = "الوصف";
                dgvMeals.Columns["Price"].HeaderText = "السعر";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"حدث خطأ أثناء تحميل قائمة الوجبات: {ex.Message}");
            }
        }
    }

    public static void AddMeal(string mealName, string mealDescription, string mealPrice, DataGridView dgvMeals)
    {
        using (SqlConnection connection = new SqlConnection(strconnection))
        {
            try
            {
                connection.Open();

                ValidateMealInput(mealName, mealDescription, mealPrice);

                string checkQuery = @"
                SELECT COUNT(*) 
                FROM Meals 
                WHERE Name = @Name AND Description = @Description AND Price = @Price";

                SqlCommand checkCommand = new SqlCommand(checkQuery, connection);
                checkCommand.Parameters.AddWithValue("@Name", mealName.Trim());
                checkCommand.Parameters.AddWithValue("@Description", mealDescription.Trim());
                checkCommand.Parameters.AddWithValue("@Price", mealPrice);

                int count = Convert.ToInt32(checkCommand.ExecuteScalar());

                if (count > 0)
                {
                    MessageBox.Show("الوجبة موجودة مسبقًا بجميع تفاصيلها. يرجى إدخال وجبة جديدة.");
                }
                else
                {
                    string insertQuery = @"
                    INSERT INTO Meals (Name, Description, Price)
                    VALUES (@Name, @Description, @Price)";

                    SqlCommand insertCommand = new SqlCommand(insertQuery, connection);
                    insertCommand.Parameters.AddWithValue("@Name", mealName.Trim());
                    insertCommand.Parameters.AddWithValue("@Description", mealDescription.Trim());
                    insertCommand.Parameters.AddWithValue("@Price", mealPrice);

                    insertCommand.ExecuteNonQuery();


                    LoadMeals(dgvMeals);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"حدث خطأ أثناء إضافة الوجبة: {ex.Message}");
            }
        }
    }

    public static void EditMeal(int mealId, string mealName, string mealDescription, string mealPrice, DataGridView dgvMeals)
    {
        using (SqlConnection connection = new SqlConnection(strconnection))
        {
            try
            {
                connection.Open();
                string query = @"
                UPDATE Meals
                SET Name = @Name, Description = @Description, Price = @Price
                WHERE MealID = @MealID";

                SqlCommand command = new SqlCommand(query, connection);

                ValidateMealInput(mealName, mealDescription, mealPrice);


                command.Parameters.AddWithValue("@Name", mealName.Trim());
                command.Parameters.AddWithValue("@Description", mealDescription.Trim());
                command.Parameters.AddWithValue("@Price", mealPrice);
                command.Parameters.AddWithValue("@MealID", mealId);

                command.ExecuteNonQuery();

                AdminMeal.LoadMeals(dgvMeals);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"حدث خطأ أثناء تعديل الوجبة: {ex.Message}");
            }
        }
    }

    public static void DeleteMeal(int mealId, DataGridView dgvMeals)
    {
        using (SqlConnection connection = new SqlConnection(strconnection))
        {
            try
            {
                connection.Open();
                string query = "DELETE FROM Meals WHERE MealID = @MealID";
                SqlCommand command = new SqlCommand(query, connection);

                command.Parameters.AddWithValue("@MealID", mealId);

                command.ExecuteNonQuery();
                MessageBox.Show("تم حذف الوجبة بنجاح!");

                AdminMeal.LoadMeals(dgvMeals);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"حدث خطأ أثناء حذف الوجبة: {ex.Message}");
            }
        }
    }
    private static void ValidateMealInput(string mealName, string mealDescription, string mealPrice)
    {
        if (string.IsNullOrEmpty(mealName) || string.IsNullOrEmpty(mealDescription) || string.IsNullOrEmpty(mealPrice))
        {
            MessageBox.Show("يرجى إدخال جميع الحقول.");
        }

        if (!decimal.TryParse(mealPrice, out _))
        {
            MessageBox.Show("يرجى إدخال سعر صالح.");
        }
    }
}
