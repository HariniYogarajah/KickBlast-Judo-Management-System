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
    public partial class Calculation : Form
    {
        CalculationClass calculationClass;
        public Calculation()
        {
            InitializeComponent();
            calculationClass = new CalculationClass(Ath_ID_label, Ath_Name_label, Training_Plan_label, Training_Plan_Fee_label, Com_Count_label, Com_Fee_label, Private_Coa_Per_Hour_label, Private_Coa_Fee_label, TotalPaymentlabel, Athlete_Name_comboBox, Start_Date_dateTimePicker, End_Date_dateTimePicker);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        

        private void Calculation_Load(object sender, EventArgs e)
        {
            calculationClass.load();
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

        
        private void Calculatebutton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to calculate monthly calculation?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                calculationClass.SearchAthlete();
            }

        }
    }
}
