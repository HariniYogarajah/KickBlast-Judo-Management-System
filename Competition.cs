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
    public partial class Competition : Form
    {
        CompetitionClass competitionClass;
        public Competition()
        {
            InitializeComponent();
            competitionClass = new CompetitionClass(Competition_IDtextBox, Competition_NametextBox, Competition_DatedateTimePicker, Entry_FeetextBox, Category_IDcomboBox, CompetitiondataGridView);
            competitionClass.load();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Entry_FeetextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Competition_DatedateTimePicker_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Competition_Load(object sender, EventArgs e)
        {

        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            competitionClass.save();
            Clear();
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            competitionClass.update();
            Clear();
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            competitionClass.delete();
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
            Competition_IDtextBox.Clear();
            Competition_NametextBox.Clear();
            Entry_FeetextBox.Clear();
        }
    }
}
