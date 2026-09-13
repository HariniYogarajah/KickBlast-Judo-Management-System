using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Judo
{
    internal class AthleteClass
    {
        private TextBox Athlete_IDtextBox, Ath_NametextBox, AgetextBox, ContacttextBox, Curr_WeighttextBox;
        private ComboBox Admin_IDcomboBox, Category_IDcomboBox, Plan_IDcomboBox;
        private DataGridView AthletedataGridView;

        public AthleteClass(TextBox Athlete_IDBox, TextBox Ath_NameBox, TextBox AgeBox, TextBox ContactBox, TextBox Curr_WeightBox, ComboBox Admin_IDBox, ComboBox Category_IDBox, ComboBox Plan_IDBox, DataGridView AthleteGrid)
        {
            Athlete_IDtextBox = Athlete_IDBox;
            Ath_NametextBox = Ath_NameBox;
            AgetextBox = AgeBox;
            ContacttextBox = ContactBox;
            Curr_WeighttextBox = Curr_WeightBox;
            Admin_IDcomboBox = Admin_IDBox;
            Category_IDcomboBox = Category_IDBox;
            Plan_IDcomboBox = Plan_IDBox;
            AthletedataGridView = AthleteGrid;

            AthletedataGridView.CellClick += Click;
        }

        public void load()
        {
            string sql = "SELECT * from Athlete";
            CommonClass.loadGridView(sql, AthletedataGridView);

            string Admin = "SELECT * from Admin;";
            CommonClass.LoadComboBox(Admin, Admin_IDcomboBox, "Admin_ID", "Name");

            string Weight_catagory = "SELECT * from Weight_catagory;";
            CommonClass.LoadComboBox(Weight_catagory, Category_IDcomboBox, "Category_ID", "Category_Name");

            string Training_plan = "SELECT * from Training_plan;";
            CommonClass.LoadComboBox(Training_plan, Plan_IDcomboBox, "Plan_ID", "Plan_Name");

        }
        public void save()
        {
            string saveSql = $"INSERT INTO Athlete (Ath_Name, Age, Contact, Curr_Weight, Admin_ID, Category_ID, Plan_ID) " +
                   $"VALUES ('{Ath_NametextBox.Text}', '{AgetextBox.Text}', '{ContacttextBox.Text}', '{Curr_WeighttextBox.Text}', '{Admin_IDcomboBox.SelectedValue}',' {Category_IDcomboBox.SelectedValue}', '{Plan_IDcomboBox.SelectedValue}');";

            CommonClass.Save(saveSql);
        }
        public void update()
        {
            string updateSql = $"UPDATE Athlete SET " +
                   $"Ath_Name = '{Ath_NametextBox.Text}', " +
                   $"Age = '{AgetextBox.Text}', " +
                   $"Contact = '{ContacttextBox.Text}', " +
                   $"Curr_Weight = '{Curr_WeighttextBox.Text}', " +
                   $"Admin_ID = '{Admin_IDcomboBox.SelectedValue}', " +
                   $"Category_ID = '{Category_IDcomboBox.SelectedValue}', " +
                   $"Plan_ID = '{Plan_IDcomboBox.SelectedValue}' " +
                   $"WHERE Athlete_ID = '{Athlete_IDtextBox.Text}';";

            CommonClass.Update(updateSql);
        }
        public void delete()
        {
            string deleteSql = $"DELETE FROM Athlete WHERE Athlete_ID = '{Athlete_IDtextBox.Text}';";
            CommonClass.Delete(deleteSql);
        }

        public void Click(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;

            Athlete_IDtextBox.Text = AthletedataGridView.Rows[rowIndex].Cells[0].Value.ToString();
            Ath_NametextBox.Text = AthletedataGridView.Rows[rowIndex].Cells[1].Value.ToString();
            AgetextBox.Text = AthletedataGridView.Rows[rowIndex].Cells[2].Value.ToString();
            ContacttextBox.Text = AthletedataGridView.Rows[rowIndex].Cells[3].Value.ToString();
            Curr_WeighttextBox.Text = AthletedataGridView.Rows[rowIndex].Cells[4].Value.ToString();
            Admin_IDcomboBox.Text = AthletedataGridView.Rows[rowIndex].Cells[5].Value.ToString();
            Category_IDcomboBox.Text = AthletedataGridView.Rows[rowIndex].Cells[6].Value.ToString();
            Plan_IDcomboBox.Text = AthletedataGridView.Rows[rowIndex].Cells[7].Value.ToString();
           
        }
    }
}

