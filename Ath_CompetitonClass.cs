using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Judo
{
    internal class Ath_CompetitonClass
    {
        private TextBox Ath_comp_IDtextBox;
        private DateTimePicker Register_DatedateTimePicker;
        private ComboBox Athlete_IDcomboBox, Competition_IDcomboBox;
        private DataGridView Ath_CompetitondataGridView;

        public Ath_CompetitonClass(TextBox Ath_comp_IDBox, DateTimePicker Register_DateBox, ComboBox Athlete_IDBox, ComboBox Competition_IDBox,  DataGridView Ath_CompetitonGrid)
        {
            Ath_comp_IDtextBox = Ath_comp_IDBox;
            Register_DatedateTimePicker = Register_DateBox;
            Athlete_IDcomboBox = Athlete_IDBox;
            Competition_IDcomboBox = Competition_IDBox;
            Ath_CompetitondataGridView = Ath_CompetitonGrid;

            Ath_CompetitondataGridView.CellClick += Click;
        }

        public void load()
        {
            string sql = "SELECT * from Ath_Competiton";
            CommonClass.loadGridView(sql, Ath_CompetitondataGridView);

            string Athlete = "SELECT * from Athlete;";
            CommonClass.LoadComboBox(Athlete, Athlete_IDcomboBox, "Ath_Name", "Athlete_ID");

            string Competition = "SELECT * from Competition;";
            CommonClass.LoadComboBox(Competition, Competition_IDcomboBox, "Competition_Name", "Competition_ID");

        }
        public void save()
        {
            string saveSql = $"INSERT INTO Ath_Competiton (Register_Date, Athlete_ID, Competition_ID) " +
                  $"VALUES ('{Register_DatedateTimePicker.Value.ToString("yyyy-MM-dd")}', {Athlete_IDcomboBox.Text}, {Competition_IDcomboBox.Text});";

            CommonClass.Save(saveSql);
        }
        public void update()
        {
            string updateSql = $"UPDATE Ath_Competiton SET " +
                   $"Register_Date = '{Register_DatedateTimePicker.Value.ToString("yyyy-MM-dd")}', " +
                   $"Athlete_ID = {Athlete_IDcomboBox.Text}, " +
                   $"Competition_ID = {Competition_IDcomboBox.Text} " +
                   $"WHERE Ath_comp_ID = {Ath_comp_IDtextBox.Text};";

            CommonClass.Update(updateSql);
        }
        public void delete()
        {
            string deleteSql = $"DELETE FROM Ath_Competiton WHERE Ath_comp_ID = {Ath_comp_IDtextBox.Text};";
            CommonClass.Delete(deleteSql);
        }

        public void Click(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;

            Ath_comp_IDtextBox.Text = Ath_CompetitondataGridView.Rows[rowIndex].Cells[0].Value.ToString();
            Register_DatedateTimePicker.Text = Ath_CompetitondataGridView.Rows[rowIndex].Cells[1].Value.ToString();
            Athlete_IDcomboBox.Text = Ath_CompetitondataGridView.Rows[rowIndex].Cells[2].Value.ToString();
            Competition_IDcomboBox.Text = Ath_CompetitondataGridView.Rows[rowIndex].Cells[3].Value.ToString();
           

        }
    }
}
