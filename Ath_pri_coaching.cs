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
    public partial class Ath_pri_coaching : Form
    {
        Ath_pri_coachingClass ath_Pri_CoachingClass;
        public Ath_pri_coaching()
        {
            InitializeComponent();
            ath_Pri_CoachingClass = new Ath_pri_coachingClass(Ath_pri_coach_IDtextBox, Starting_DatedateTimePicker, Ending_DatedateTimePicker, Athlete_IDcomboBox, Coach_IDcomboBox, Ath_pri_coachingdataGridView);
            ath_Pri_CoachingClass.load();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Ath_pri_coaching_Load(object sender, EventArgs e)
        {

        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            ath_Pri_CoachingClass.save();
            Clear();
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            ath_Pri_CoachingClass.update();
            Clear();
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            ath_Pri_CoachingClass.delete();
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
            Ath_pri_coach_IDtextBox.Clear();           
        }
    }
}
