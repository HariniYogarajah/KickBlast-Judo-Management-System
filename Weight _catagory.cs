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
    public partial class Weight__catagory : Form
    {
        Weight__catagoryClass weight__CatagoryClass;
        public Weight__catagory()
        {
            InitializeComponent();
            weight__CatagoryClass = new Weight__catagoryClass(Category_IDtextBox, Category_NametextBox, min_weighttextBox, max_weighttextBox, Weight_catagorydataGridView);
            weight__CatagoryClass.load();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Category_NametextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Weight__catagory_Load(object sender, EventArgs e)
        {

        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            weight__CatagoryClass.save();
            Clear();
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            weight__CatagoryClass.update();
            Clear();
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            weight__CatagoryClass.delete();
            Clear();
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
            Category_IDtextBox.Clear();
            Category_NametextBox.Clear();
            min_weighttextBox.Clear();
            max_weighttextBox.Clear();          
        }
    }
}
