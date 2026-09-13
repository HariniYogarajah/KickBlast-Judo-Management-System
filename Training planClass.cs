using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Judo
{
    internal class Training_planClass
    {
        private TextBox Plan_IDtextBox, Plan_NametextBox, Session_Per_WeektextBox, Mon_FeetextBox;
        private DataGridView Training_plandataGridView;

        public Training_planClass(TextBox Plan_IDBox, TextBox Plan_NameBox, TextBox Session_Per_WeekBox, TextBox Mon_FeeBox, DataGridView Training_planGrid)
        {
            Plan_IDtextBox = Plan_IDBox;
            Plan_NametextBox = Plan_NameBox;
            Session_Per_WeektextBox = Session_Per_WeekBox;
            Mon_FeetextBox = Mon_FeeBox;
            Training_plandataGridView = Training_planGrid;

            Training_plandataGridView.CellClick += Click;
        }

        public void load()
        {
            string sql = "SELECT * from Training_plan";
            CommonClass.loadGridView(sql, Training_plandataGridView);

        }
        public void save()
        {
            string saveSql = $"INSERT INTO Training_plan (Plan_Name, Session_Per_Week, Mon_Fee) " +
                  $"VALUES ('{Plan_NametextBox.Text}', '{Session_Per_WeektextBox.Text}', '{Mon_FeetextBox.Text}');";

            CommonClass.Save(saveSql);
        }
        public void update()
        {
            string updateSql = $"UPDATE Training_plan SET " +
                     $"Plan_Name = '{Plan_NametextBox.Text}', " +
                     $"Session_Per_Week = '{Session_Per_WeektextBox.Text}', " +
                     $"Mon_Fee = '{Mon_FeetextBox.Text}' " +
                     $"WHERE Plan_ID = '{Plan_IDtextBox.Text}';";

            CommonClass.Update(updateSql);
        }
        public void delete()
        {
            string deleteSql = $"DELETE FROM Training_plan WHERE Plan_ID = '{Plan_IDtextBox.Text}';";
            CommonClass.Delete(deleteSql);
        }

        public void Click(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;

            Plan_IDtextBox.Text = Training_plandataGridView.Rows[rowIndex].Cells[0].Value.ToString();
            Plan_NametextBox.Text = Training_plandataGridView.Rows[rowIndex].Cells[1].Value.ToString();
            Session_Per_WeektextBox.Text = Training_plandataGridView.Rows[rowIndex].Cells[2].Value.ToString();
            Mon_FeetextBox.Text = Training_plandataGridView.Rows[rowIndex].Cells[3].Value.ToString();


        }
    }
}
