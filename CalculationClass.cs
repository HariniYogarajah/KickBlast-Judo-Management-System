using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection.Emit;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using Label = System.Windows.Forms.Label;

namespace Judo
{
    internal class CalculationClass 

    {
        private Label Ath_ID_label, Ath_Name_label, Training_Plan_label, Training_Plan_Fee_label, Com_Count_label, Com_Fee_label, Private_Coa_Per_Hour_label, Private_Coa_Fee_label, TotalPaymentlabel;
        private ComboBox Athlete_Name_comboBox;
        private DateTimePicker Start_Date_dateTimePicker, End_Date_dateTimePicker;

        private int totalweeks;
        private float TotalCoachingHours, PlanFeeValue, CompetitionFeeValue, PrivateCoachingFeeValue, TotalFeeValue;
        private DataTable athleteTable, privateCoachingTable, competitionTable;

        public CalculationClass(Label ath_ID_label, Label ath_Name_label, Label training_Plan_label, Label training_Plan_Fee_label, Label com_Count_label, Label com_Fee_label, Label private_Coa_Per_Hour_label,  Label private_Coa_Fee_label, Label totalPaymentlabel, ComboBox athlete_Name_comboBox, DateTimePicker start_Date_dateTimePicker, DateTimePicker end_Date_dateTimePicker)
        {
            Ath_ID_label = ath_ID_label;
            Ath_Name_label = ath_Name_label;
            Training_Plan_label = training_Plan_label;
            Training_Plan_Fee_label = training_Plan_Fee_label;
            Com_Count_label = com_Count_label;
            Com_Fee_label = com_Fee_label;
            Private_Coa_Per_Hour_label = private_Coa_Per_Hour_label;
            Private_Coa_Fee_label = private_Coa_Fee_label;
            TotalPaymentlabel = totalPaymentlabel;
            Athlete_Name_comboBox = athlete_Name_comboBox;
            Start_Date_dateTimePicker = start_Date_dateTimePicker;
            End_Date_dateTimePicker = end_Date_dateTimePicker;

            athleteTable = new DataTable();
            privateCoachingTable = new DataTable();
            competitionTable = new DataTable();
        }
        public void load()
        {
            string Athlete = "SELECT Athlete_ID, Ath_Name FROM Athlete";
            CommonClass.LoadComboBox(Athlete, Athlete_Name_comboBox, "Athlete_ID", "Ath_Name");
        }

        // Calculates the total fee for the training plan based on the number of weeks
        // the athlete is enrolled and the monthly fee of the selected plan.
        private void trainingPlanCalculate()
        {
            PlanFeeValue = totalweeks * Convert.ToSingle(athleteTable.Rows[0]["Mon_Fee"]);
        }

        private void competitionCalculate()
        {
            foreach (DataRow row in competitionTable.Rows)
            {
                CompetitionFeeValue += Convert.ToSingle(row["Competition_Fee"]);
            }
        }

        private void privateCoachingCalculate()
        {
            foreach (DataRow row in privateCoachingTable.Rows)
            {
                float feePerHour = Convert.ToSingle(row["Hourly_Rate"]);
                float totalMinutes = Convert.ToSingle(row["Total_MINUTES"]);
                TotalCoachingHours = totalMinutes / 60;
                PrivateCoachingFeeValue += feePerHour * TotalCoachingHours;
            }
        }

        private void TotalFeeCalculate()
        {
            TotalFeeValue = PlanFeeValue + CompetitionFeeValue + PrivateCoachingFeeValue;
        }

        public void displayDatas()
        {
            Ath_ID_label.Text = athleteTable.Rows[0]["Athlete_ID"].ToString();
            Ath_Name_label.Text = athleteTable.Rows[0]["Ath_Name"].ToString();
            Training_Plan_label.Text = athleteTable.Rows[0]["Plan_Name"].ToString();
            Com_Count_label.Text = competitionTable.Rows.Count.ToString();
            Private_Coa_Per_Hour_label.Text = TotalCoachingHours.ToString("0.00") + " hours";
            Training_Plan_Fee_label.Text = PlanFeeValue.ToString("0.00");
            Com_Fee_label.Text = CompetitionFeeValue.ToString("0.00");
            Private_Coa_Fee_label.Text = PrivateCoachingFeeValue.ToString("0.00");
            TotalPaymentlabel.Text = TotalFeeValue.ToString("0.00");
        }
        // Retrieves athlete, private coaching, and competition data from the database
        // based on the selected athlete and the chosen date range.
        private void fetchDatas()
        {
            string findsql = $"SELECT a.Athlete_ID,a.Ath_Name,t.Plan_Name, t.Mon_Fee from Athlete a join Training_plan t on a.Plan_ID = t.Plan_ID WHERE a.Athlete_ID = {Athlete_Name_comboBox.SelectedValue.ToString()};"
                + $"SELECT A.Ath_Name AS Ath_Name, PC.Coach_Name AS Coach_Name, P.Starting_Date, P.Ending_Date,DATEDIFF (MINUTE, P.Starting_Date, P.Ending_Date) AS Total_MINUTES, Hourly_Rate FROM Ath_pri_coaching P INNER JOIN Private_coaching PC ON P.Coach_ID = PC.Coach_ID INNER JOIN Athlete A ON P.Athlete_ID = A.Athlete_ID WHERE P.Athlete_ID = {Athlete_Name_comboBox.SelectedValue.ToString()} AND P.Starting_Date BETWEEN '{Start_Date_dateTimePicker.Value.ToString()}' AND '{End_Date_dateTimePicker.Value.ToString()}' ORDER BY P.Starting_Date;"
                + $"SELECT CR.Athlete_ID, A.Ath_Name AS Ath_Name, CR.Register_Date, C.Competition_Name, C.Entry_Fee FROM Ath_Competiton CR INNER JOIN Competition C ON CR.Competition_ID = C.Competition_ID INNER JOIN Athlete A ON CR.Athlete_ID = A.Athlete_ID WHERE CR.Athlete_ID = {Athlete_Name_comboBox.SelectedValue.ToString()} AND CR.Register_Date BETWEEN '{Start_Date_dateTimePicker.Value.ToString()}' AND '{End_Date_dateTimePicker.Value.ToString()}' ORDER BY CR.Register_Date;";

                DataSet athleteDataSet = CommonClass.GetDataSet(findsql);
                athleteTable = athleteDataSet.Tables[0];
                privateCoachingTable = athleteDataSet.Tables[1];
                competitionTable = athleteDataSet.Tables[2];
        }

        private Boolean findWeeksCount()
        {
            DateTime startDate = Start_Date_dateTimePicker.Value.Date;
            DateTime endDate = End_Date_dateTimePicker.Value.Date;

            if (endDate > startDate)
            {
                TimeSpan difference = endDate - startDate;
                int totalDays = difference.Days;

                totalweeks = totalDays / 7;

                if (totalDays % 7 != 0)
                {
                    totalweeks += 1;
                }
                return true;
            }
            else
            {
                return false;
            }
        }

        // This method searches for an athlete and calculates all associated fees
        // if the selected date range is valid. It calls all calculation methods and displays results.
        public void SearchAthlete()
        {
            if (findWeeksCount())
            {
                fetchDatas();
                privateCoachingCalculate();
                competitionCalculate();
                trainingPlanCalculate();
                TotalFeeCalculate();
                displayDatas();
            }
            else
            {
                MessageBox.Show("Please select valid dates to calculate the payment.");
            }

        }
    }

}

