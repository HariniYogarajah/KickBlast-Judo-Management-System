using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Judo
{
    public partial class Ath_Competiton : Form
    {
        Ath_CompetitonClass ath_CompetitonClass;
        public Ath_Competiton()
        {
            InitializeComponent();
            ath_CompetitonClass = new Ath_CompetitonClass(Ath_comp_IDtextBox, Register_DatedateTimePicker, Athlete_IDcomboBox, Competition_IDcomboBox, Ath_CompetitondataGridView);
            ath_CompetitonClass.load();
        }

        private void Ath_Competiton_Load(object sender, EventArgs e)
        {

        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            ath_CompetitonClass.save();
            Clear();
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            ath_CompetitonClass.update();
            Clear();
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            ath_CompetitonClass.delete();
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
            Ath_comp_IDtextBox.Clear();
        }
    }
}
