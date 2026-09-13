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
    public partial class Training_plan : Form
    {
        Training_planClass training_PlanClass;
        public Training_plan()
        {
            InitializeComponent();
            training_PlanClass = new Training_planClass(Plan_IDtextBox, Plan_NametextBox, Session_Per_WeektextBox, Mon_FeetextBox, Training_plandataGridView);
            training_PlanClass.load();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Plan_NametextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Training_plan_Load(object sender, EventArgs e)
        {

        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            training_PlanClass.save();
            Clear();
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            training_PlanClass.update();
            Clear();
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            training_PlanClass.delete();
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
            Plan_IDtextBox.Clear();
            Plan_NametextBox.Clear();
            Session_Per_WeektextBox.Clear();
            Mon_FeetextBox.Clear();          
        }
    }
}
