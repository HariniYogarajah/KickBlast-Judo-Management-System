using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Judo
{
    
    internal class CompetitionClass
    {

        private TextBox Competition_IDtextBox, Competition_NametextBox, Entry_FeetextBox;
        private DateTimePicker Competition_DatedateTimePicker;
        private ComboBox Category_IDcomboBox;
        private DataGridView CompetitiondataGridView;

        public CompetitionClass(TextBox Competition_IDBox, TextBox Competition_NameBox, DateTimePicker Competition_DateBox, TextBox Entry_FeeBox, ComboBox Category_IDBox, DataGridView CompetitionGrid)
        {
            Competition_IDtextBox = Competition_IDBox;
            Competition_NametextBox = Competition_NameBox;
            Competition_DatedateTimePicker = Competition_DateBox;
            Entry_FeetextBox = Entry_FeeBox;
            Category_IDcomboBox = Category_IDBox;
            CompetitiondataGridView = CompetitionGrid;

            CompetitiondataGridView.CellClick += Click;
        }

        public void load()
        {
            string sql = "SELECT * from Competition";
            CommonClass.loadGridView(sql, CompetitiondataGridView);

            string Weight_catagory = "SELECT * from Weight_catagory;";
            CommonClass.LoadComboBox(Weight_catagory, Category_IDcomboBox, "Category_Name", "Category_ID");

        }
        public void save()
        {
            string saveSql = $"INSERT INTO Competition (Competition_Name, Competition_Date, Entry_Fee, Category_ID) " +
                  $"VALUES ('{Competition_NametextBox.Text}', '{Competition_DatedateTimePicker.Value.ToString("yyyy/MM/dd")}', {Entry_FeetextBox.Text}, {Category_IDcomboBox.SelectedValue});";

            CommonClass.Save(saveSql);
        }
        public void update()
        {
            string updateSql = $"UPDATE Competition SET " +
                    $"Competition_Name = '{Competition_NametextBox.Text}', " +
                    $"Competition_Date = '{Competition_DatedateTimePicker.Value.ToString("yyyy/MM/dd")}', " +
                    $"Entry_Fee = {Entry_FeetextBox.Text}, " +
                    $"Category_ID = {Category_IDcomboBox.SelectedValue} " +
                    $"WHERE Competition_ID = {Competition_IDtextBox.Text};";

            CommonClass.Update(updateSql);
        }
        public void delete()
        {
            string deleteSql = $"DELETE FROM Competition WHERE  Competition_ID = {Competition_IDtextBox.Text};";
            CommonClass.Delete(deleteSql);
        }

        public void Click(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;

            Competition_IDtextBox.Text = CompetitiondataGridView.Rows[rowIndex].Cells[0].Value.ToString();
            Competition_NametextBox.Text = CompetitiondataGridView.Rows[rowIndex].Cells[1].Value.ToString();
            Competition_DatedateTimePicker.Text = CompetitiondataGridView.Rows[rowIndex].Cells[2].Value.ToString();
            Entry_FeetextBox.Text = CompetitiondataGridView.Rows[rowIndex].Cells[3].Value.ToString();
            Category_IDcomboBox.Text = CompetitiondataGridView.Rows[rowIndex].Cells[4].Value.ToString();
        }
    }
}
