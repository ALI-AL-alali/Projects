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
    public partial class LoginForm : Form
    {

        public LoginForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUser.Text;
            string password = txtPass.Text;

            int? userId = LoginUser.Authenticate(username, password);

            if (userId.HasValue)
            {
                LoginUser.OpenAppropriateForm(username, userId.Value);
                this.Hide();
            }
            else
            {
                MessageBox.Show("فشل تسجيل الدخول. يرجى المحاولة مرة أخرى.");
            }
        }
        
    }
}
