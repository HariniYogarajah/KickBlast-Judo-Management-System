using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Judo
{
    internal class Ath_pri_coachingClass
    {
        private TextBox Ath_pri_coach_IDtextBox;
        private DateTimePicker Starting_DatedateTimePicker, Ending_DatedateTimePicker;
        private ComboBox Athlete_IDcomboBox, Coach_IDcomboBox;
        private DataGridView Ath_pri_coachingdataGridView;

        public Ath_pri_coachingClass(TextBox Ath_pri_coach_IDBox, DateTimePicker Starting_DateBox, DateTimePicker Ending_DatedateBox, ComboBox Athlete_IDBox, ComboBox Coach_IDBox, DataGridView Ath_pri_coachingGrid)
        {
            Ath_pri_coach_IDtextBox = Ath_pri_coach_IDBox;
            Starting_DatedateTimePicker = Starting_DateBox;
            Ending_DatedateTimePicker = Ending_DatedateBox;
            Athlete_IDcomboBox = Athlete_IDBox;
            Coach_IDcomboBox = Coach_IDBox;
            Ath_pri_coachingdataGridView = Ath_pri_coachingGrid;

            Ath_pri_coachingdataGridView.CellClick += Click;
        }

        public void load()
        {
            string sql = "SELECT * from Ath_pri_coaching";
            CommonClass.loadGridView(sql, Ath_pri_coachingdataGridView);

            string Athlete = "SELECT * from Athlete;";
            CommonClass.LoadComboBox(Athlete, Athlete_IDcomboBox, "Ath_Name", "Athlete_ID");

            string Private_coaching = "SELECT * from Private_coaching;";
            CommonClass.LoadComboBox(Private_coaching, Coach_IDcomboBox, "Coach_Name", "Coach_ID");
        }
        public void save()
        {
            string saveSql = $"INSERT INTO Ath_pri_coaching (Starting_Date, Ending_Date, Athlete_ID, Coach_ID) " +
                  $"VALUES ('{Starting_DatedateTimePicker.Value.ToString("yyyy-MM-dd HH:mm:ss")}', " +
                  $"'{Ending_DatedateTimePicker.Value.ToString("yyyy-MM-dd HH:mm:ss")}', " +
                  $"{Athlete_IDcomboBox.Text}, {Coach_IDcomboBox.Text});";

            CommonClass.Save(saveSql);
        }
        public void update()
        {
            string updateSql = $"UPDATE Ath_pri_coaching SET " +
                   $"Starting_Date = '{Starting_DatedateTimePicker.Value.ToString("yyyy-MM-dd HH:mm:ss")}', " +
                   $"Ending_Date = '{Ending_DatedateTimePicker.Value.ToString("yyyy-MM-dd HH:mm:ss")}', " +
                   $"Athlete_ID = {Athlete_IDcomboBox.Text}, " +
                   $"Coach_ID = {Coach_IDcomboBox.Text} " +
                   $"WHERE Ath_pri_coach_ID = {Ath_pri_coach_IDtextBox.Text};";

            CommonClass.Update(updateSql);
        }
        public void delete()
        {
            string deleteSql = $"DELETE FROM Ath_pri_coaching WHERE  Ath_pri_coach_ID = {Ath_pri_coach_IDtextBox.Text};";
            CommonClass.Delete(deleteSql);
        }

        public void Click(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;

            Ath_pri_coach_IDtextBox.Text = Ath_pri_coachingdataGridView.Rows[rowIndex].Cells[0].Value.ToString();
            Starting_DatedateTimePicker.Text = Ath_pri_coachingdataGridView.Rows[rowIndex].Cells[1].Value.ToString();
            Ending_DatedateTimePicker.Text = Ath_pri_coachingdataGridView.Rows[rowIndex].Cells[2].Value.ToString();
            Athlete_IDcomboBox.Text = Ath_pri_coachingdataGridView.Rows[rowIndex].Cells[3].Value.ToString();
            Coach_IDcomboBox.Text = Ath_pri_coachingdataGridView.Rows[rowIndex].Cells[4].Value.ToString();


        }
    }
}

    

