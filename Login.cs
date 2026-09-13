using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Judo
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }


        public void lLogin()
        {
            string Username = User_NametextBox.Text.Trim();
            string Upassword = PasswordtextBox.Text.Trim();

          
            if (Username == "" || Upassword == "")
            {
                MessageBox.Show("Fill all box!");
                return;
            }

          
            string sql = $"SELECT User_Name, Password FROM Admin " +
                         $"WHERE User_Name = '{Username}' AND Password = '{Upassword}'";

            DataTable dt = CommonClass.login_data(sql);

            if (dt.Rows.Count > 0)
            {
                MessageBox.Show("Login Success");

                User_NametextBox.Clear();
                PasswordtextBox.Clear();

                
            }
            else
            {
                MessageBox.Show("Invalid Username or Password!");
            }
        }
        private void CancelButton_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        public void Clear()
        {
            User_NametextBox.Clear();
            PasswordtextBox.Clear();

        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            lLogin();
        }
    }
}








