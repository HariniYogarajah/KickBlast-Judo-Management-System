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
    public partial class Monthly__pay : Form
    {
        Monthly__payClass monthly__PayClass;
        public Monthly__pay()
        {
            InitializeComponent();
            monthly__PayClass = new Monthly__payClass(Pay_IDtextBox, Pri_coach_feetextBox, MonthdateTimePicker, Train_FeetextBox, Competition_feetextBox, TotaltextBox, Athlete_IDcomboBox, Monthly_paydataGridView);
            monthly__PayClass.load();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Monthly__pay_Load(object sender, EventArgs e)
        {

        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            monthly__PayClass.save();
            Clear();
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            monthly__PayClass.update();
            Clear();
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            monthly__PayClass.delete();
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
            Pay_IDtextBox.Clear();
            Pri_coach_feetextBox.Clear();
            Train_FeetextBox.Clear();
            Competition_feetextBox.Clear();
            TotaltextBox.Clear();
        }
    }
}
