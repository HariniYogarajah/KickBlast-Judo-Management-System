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
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {

        }

        private void Weight_catagorybutton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Weight__catagory weight__Catagory = new Weight__catagory();
            weight__Catagory.Show();

        }

        private void Adminbutton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Admin admin = new Admin();
            admin.Show();
        }

        private void Athletebutton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Athlete athlete = new Athlete();
            athlete.Show();
        }

        private void Calculationbutton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Calculation calculation = new Calculation();
            calculation.Show();
        }

        private void Competitionbutton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Competition competition = new Competition();
            competition.Show();
        }

        private void Private_coachingbutton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Private_coaching private_Coaching = new Private_coaching();
            private_Coaching.Show();
        }

        private void Training_planbutton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Training_plan training_Plan = new Training_plan();
            training_Plan.Show();
        }
     
        private void Ath_pri_coachingbutton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Ath_pri_coaching ath_Pri_Coaching = new Ath_pri_coaching();
            ath_Pri_Coaching.Show();
        }

        private void Ath_Competitonbutton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Ath_Competiton ath_Competiton = new Ath_Competiton();
            ath_Competiton.Show();
        }

        private void Monthly_paybutton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Monthly__pay monthly__Pay = new Monthly__pay();
            monthly__Pay.Show();
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void LogoutBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You have logged out successfully.", "Logout", MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.Hide();
            Login log = new Login();
            log.Show();
        }
    }
}
