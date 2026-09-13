using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Judo
{
    internal class Weight__catagoryClass
    {
        private TextBox Category_IDtextBox, Category_NametextBox, min_weighttextBox, max_weighttextBox;
        private DataGridView Weight_catagorydataGridView;

        public Weight__catagoryClass(TextBox Category_IDBox, TextBox Category_NameBox, TextBox min_weightBox, TextBox max_weightBox, DataGridView Weight_catagoryGrid)
        {
            Category_IDtextBox = Category_IDBox;
            Category_NametextBox = Category_NameBox;
            min_weighttextBox = min_weightBox;
            max_weighttextBox = max_weightBox;
            Weight_catagorydataGridView = Weight_catagoryGrid;

            Weight_catagorydataGridView.CellClick += Click;
        }

        public void load()
        {
            string sql = "SELECT * from Weight_catagory";
            CommonClass.loadGridView(sql, Weight_catagorydataGridView);

        }
        public void save()
        {
            string saveSql = $"INSERT INTO Weight_catagory (Category_Name, min_weight, max_weight) " +
                  $"VALUES ('{Category_NametextBox.Text}', {min_weighttextBox.Text}, {max_weighttextBox.Text});";

            CommonClass.Save(saveSql);
        }
        public void update()
        {
            string updateSql = $"UPDATE Weight_catagory SET " +
                     $"Category_Name = '{Category_NametextBox.Text}', " +
                     $"min_weight = {min_weighttextBox.Text}, " +
                     $"max_weight = {max_weighttextBox.Text} " +
                     $"WHERE Category_ID = {Category_IDtextBox.Text};";

            CommonClass.Update(updateSql);
        }
        public void delete()
        {
            string deleteSql = $"DELETE FROM Weight_catagory WHERE Category_ID = {Category_IDtextBox.Text};";
            CommonClass.Delete(deleteSql);
        }

        public void Click(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;

            Category_IDtextBox.Text = Weight_catagorydataGridView.Rows[rowIndex].Cells[0].Value.ToString();
            Category_NametextBox.Text = Weight_catagorydataGridView.Rows[rowIndex].Cells[1].Value.ToString();
            min_weighttextBox.Text = Weight_catagorydataGridView.Rows[rowIndex].Cells[2].Value.ToString();
            max_weighttextBox.Text = Weight_catagorydataGridView.Rows[rowIndex].Cells[3].Value.ToString();


        }
    }
}
