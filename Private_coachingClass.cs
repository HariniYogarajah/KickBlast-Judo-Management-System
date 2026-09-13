using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Judo
{
    internal class Private_coachingClass
    {

        private TextBox Coach_IDtextBox, Coach_NametextBox, Hourly_RatetextBox;
        private DataGridView Private_coachingdataGridView;

        public Private_coachingClass(TextBox Coach_IDBox, TextBox Coach_NameBox, TextBox Hourly_RateBox,  DataGridView Private_coachingGrid)
        {
            Coach_IDtextBox = Coach_IDBox;
            Coach_NametextBox = Coach_NameBox;
            Hourly_RatetextBox = Hourly_RateBox;
            Private_coachingdataGridView = Private_coachingGrid;

            Private_coachingdataGridView.CellClick += Click;
        }

        public void load()
        {
            string sql = "SELECT * from Private_coaching";
            CommonClass.loadGridView(sql, Private_coachingdataGridView);

        }
        public void save()
        {
            string saveSql = $"INSERT INTO Private_coaching (Coach_Name, Hourly_Rate) " +
                   $"VALUES ('{Coach_NametextBox.Text}', {Hourly_RatetextBox.Text});";
            CommonClass.Save(saveSql);
        }
        public void update()
        {
            string updateSql = $"UPDATE Private_coaching SET " +
                     $"Coach_Name = '{Coach_NametextBox.Text}', " +
                     $"Hourly_Rate = {Hourly_RatetextBox.Text} " +
                     $"WHERE Coach_ID = {Coach_IDtextBox.Text};";

            CommonClass.Update(updateSql);
        }
        public void delete()
        {
            string deleteSql = $"DDELETE FROM Private_coaching WHERE Coach_ID = {Coach_IDtextBox.Text};";
            CommonClass.Delete(deleteSql);
        }

        public void Click(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;

            Coach_IDtextBox.Text = Private_coachingdataGridView.Rows[rowIndex].Cells[0].Value.ToString();
            Coach_NametextBox.Text = Private_coachingdataGridView.Rows[rowIndex].Cells[1].Value.ToString();
            Hourly_RatetextBox.Text = Private_coachingdataGridView.Rows[rowIndex].Cells[2].Value.ToString();
           
        }
    }
}
