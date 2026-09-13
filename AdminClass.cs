using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Judo
{
    internal class AdminClass
    {
        private TextBox Admin_IDtextBox, NametextBox, ContacttextBox, User_NametextBox, PasswordtextBox;
        private DataGridView AdmindataGridView;
    


       public AdminClass(TextBox Admin_IDBox, TextBox NameBox, TextBox ContactBox, TextBox User_NameBox, TextBox PasswordBox, DataGridView AdminGrid)
        {
            Admin_IDtextBox = Admin_IDBox;
            NametextBox = NameBox;
            ContacttextBox = ContactBox;
            User_NametextBox = User_NameBox;
            PasswordtextBox = PasswordBox;
            AdmindataGridView = AdminGrid;

            AdmindataGridView.CellClick += Click;
        }

        public void load()
        {
            string sql = "SELECT * from Admin";
            CommonClass.loadGridView(sql, AdmindataGridView);      

        }
        public void save()
        {
            string saveSql = $"INSERT INTO Admin (Name, Contact, User_Name, Password) " +
                  $"VALUES ('{NametextBox.Text}', {ContacttextBox.Text}, '{User_NametextBox.Text}', '{PasswordtextBox.Text}');";

            CommonClass.Save(saveSql);

            CommonClass.Save(saveSql);
        }
        public void update()
        {
            string updateSql = $"UPDATE Admin SET Name = '{NametextBox.Text}', Contact = {ContacttextBox.Text}, User_Name = '{User_NametextBox.Text}', Password = '{PasswordtextBox.Text}' WHERE Admin_ID = {Admin_IDtextBox.Text};";
            CommonClass.Update(updateSql);
        }
        public void delete()
        {
            string deleteSql = $"DELETE FROM Admin WHERE Admin_ID = {Admin_IDtextBox.Text};";
            CommonClass.Delete(deleteSql);
        }

        public void Click(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;

            Admin_IDtextBox.Text = AdmindataGridView.Rows[rowIndex].Cells[0].Value.ToString();
            NametextBox.Text = AdmindataGridView.Rows[rowIndex].Cells[1].Value.ToString();
            ContacttextBox.Text = AdmindataGridView.Rows[rowIndex].Cells[2].Value.ToString();
            User_NametextBox.Text = AdmindataGridView.Rows[rowIndex].Cells[3].Value.ToString();
            PasswordtextBox.Text = AdmindataGridView.Rows[rowIndex].Cells[4].Value.ToString();




        }
    }
}
