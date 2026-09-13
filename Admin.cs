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
    public partial class Admin : Form
    {
        AdminClass adminClass;
        public Admin()
        {
            InitializeComponent();
            adminClass = new AdminClass (Admin_IDtextBox, NametextBox, ContacttextBox, User_NametextBox, PasswordtextBox, AdmindataGridView);
            adminClass.load();
        }

        private void Admin_Load(object sender, EventArgs e)
        {

        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            adminClass.save();
            Clear();
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            adminClass.update();
            Clear();
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            adminClass.delete();
        }

        private void ClearBtn_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void DashboardBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Dashboard dashboard = new Dashboard();
            dashboard.Show();
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public void Clear()
        {
            Admin_IDtextBox.Clear();
            NametextBox.Clear();
            ContacttextBox.Clear();
            User_NametextBox.Clear();
            PasswordtextBox.Clear();
        }
    }
}
