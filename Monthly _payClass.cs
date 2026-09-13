using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Judo
{
    internal class Monthly__payClass
    {

        private TextBox Pay_IDtextBox, Pri_coach_feetextBox, Train_FeetextBox, Competition_feetextBox, TotaltextBox;
        private DateTimePicker MonthdateTimePicker;
        private ComboBox Athlete_IDcomboBox;
        private DataGridView Monthly_paydataGridView;

        public Monthly__payClass(TextBox Pay_IDBox, TextBox Pri_coach_feeBox, DateTimePicker MonthBox, TextBox Train_FeeBox, TextBox Competition_feeBox, TextBox TotalBox, ComboBox Athlete_IDBox, DataGridView Monthly_payGrid)
        {
            Pay_IDtextBox = Pay_IDBox;
            Pri_coach_feetextBox = Pri_coach_feeBox;
            MonthdateTimePicker = MonthBox;
            Train_FeetextBox = Train_FeeBox;
            Competition_feetextBox = Competition_feeBox;
            TotaltextBox = TotalBox;
            Athlete_IDcomboBox = Athlete_IDBox;
            Monthly_paydataGridView = Monthly_payGrid;

            Monthly_paydataGridView.CellClick += Click;
        }

        public void load()
        {
            string sql = "SELECT * from MonthlyPay";
            CommonClass.loadGridView(sql, Monthly_paydataGridView);

            string Athlete = "SELECT * from Athlete;";
            CommonClass.LoadComboBox(Athlete, Athlete_IDcomboBox, "Ath_Name", "Athlete_ID");

        }
        public void save()
        {
            string saveSql = $"INSERT INTO MonthlyPay (Pri_coach_fee, Month, Train_Fee, Competition_fee, Total, Athlete_ID) " +
                  $"VALUES ({Pri_coach_feetextBox.Text}, '{MonthdateTimePicker.Value.ToString("yyyy/MM/dd")}', {Train_FeetextBox.Text}, {Competition_feetextBox.Text}, {TotaltextBox.Text}, {Athlete_IDcomboBox.SelectedValue});";

            CommonClass.Save(saveSql);
        }
        public void update()
        {
            string updateSql = $"UPDATE MonthlyPay SET " +
                   $"Pri_coach_fee = {Pri_coach_feetextBox.Text}, " +
                   $"Month = '{MonthdateTimePicker.Value.ToString("yyyy/MM/dd")}', " +
                   $"Train_Fee = {Train_FeetextBox.Text}, " +
                   $"Competition_fee = {Competition_feetextBox.Text}, " +
                   $"Total = {TotaltextBox.Text}, " +
                   $"Athlete_ID = {Athlete_IDcomboBox.SelectedValue} " +
                   $"WHERE Pay_ID = {Pay_IDtextBox.Text};";

            CommonClass.Update(updateSql);
        }
        public void delete()
        {
            string deleteSql = $"DELETE FROM MonthlyPay WHERE Pay_ID = {Pay_IDtextBox.Text};";
            CommonClass.Delete(deleteSql);
        }

        public void Click(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;

            Pay_IDtextBox.Text = Monthly_paydataGridView.Rows[rowIndex].Cells[0].Value.ToString();
            Pri_coach_feetextBox.Text = Monthly_paydataGridView.Rows[rowIndex].Cells[1].Value.ToString();
            MonthdateTimePicker.Text = Monthly_paydataGridView.Rows[rowIndex].Cells[2].Value.ToString();
            Train_FeetextBox.Text = Monthly_paydataGridView.Rows[rowIndex].Cells[3].Value.ToString();
            Competition_feetextBox.Text = Monthly_paydataGridView.Rows[rowIndex].Cells[4].Value.ToString();
            TotaltextBox.Text = Monthly_paydataGridView.Rows[rowIndex].Cells[5].Value.ToString();
            Athlete_IDcomboBox.Text = Monthly_paydataGridView.Rows[rowIndex].Cells[6].Value.ToString();
        }
    }
}
