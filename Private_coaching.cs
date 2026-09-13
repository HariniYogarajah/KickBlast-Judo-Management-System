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
    public partial class Private_coaching : Form
    {
        Private_coachingClass private_CoachingClass;
        public Private_coaching()
        {
            InitializeComponent();
            private_CoachingClass = new Private_coachingClass(Coach_IDtextBox, Coach_NametextBox, Hourly_RatetextBox, Private_coachingdataGridView);
            private_CoachingClass.load();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Private_coaching_Load(object sender, EventArgs e)
        {

        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            private_CoachingClass.save();
            Clear();
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            private_CoachingClass.update();
            Clear();
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            private_CoachingClass.delete();
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
            Coach_IDtextBox.Clear();
            Coach_NametextBox.Clear();
            Hourly_RatetextBox.Clear();
        }
    }
}
