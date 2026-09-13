namespace Judo
{
    partial class Ath_pri_coaching
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Ath_pri_coach_IDtextBox = new System.Windows.Forms.TextBox();
            this.Athlete_IDcomboBox = new System.Windows.Forms.ComboBox();
            this.Coach_IDcomboBox = new System.Windows.Forms.ComboBox();
            this.Ath_pri_coachingdataGridView = new System.Windows.Forms.DataGridView();
            this.Starting_DatedateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.Ending_DatedateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.ClearBtn = new System.Windows.Forms.Button();
            this.DeleteBtn = new System.Windows.Forms.Button();
            this.UpdateBtn = new System.Windows.Forms.Button();
            this.SaveBtn = new System.Windows.Forms.Button();
            this.closeBtn = new System.Windows.Forms.Button();
            this.DashboardBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Ath_pri_coachingdataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(227, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(346, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ath_pri_coaching";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(79, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(201, 26);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ath_pri_coach_ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(79, 217);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(158, 26);
            this.label3.TabIndex = 2;
            this.label3.Text = "Starting_Date";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(79, 303);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(149, 26);
            this.label4.TabIndex = 3;
            this.label4.Text = "Ending_Date";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(79, 389);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(124, 26);
            this.label5.TabIndex = 4;
            this.label5.Text = "Athlete_ID";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(79, 483);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(117, 26);
            this.label6.TabIndex = 5;
            this.label6.Text = "Coach_ID";
            // 
            // Ath_pri_coach_IDtextBox
            // 
            this.Ath_pri_coach_IDtextBox.Location = new System.Drawing.Point(299, 146);
            this.Ath_pri_coach_IDtextBox.Name = "Ath_pri_coach_IDtextBox";
            this.Ath_pri_coach_IDtextBox.ReadOnly = true;
            this.Ath_pri_coach_IDtextBox.Size = new System.Drawing.Size(274, 26);
            this.Ath_pri_coach_IDtextBox.TabIndex = 6;
            // 
            // Athlete_IDcomboBox
            // 
            this.Athlete_IDcomboBox.FormattingEnabled = true;
            this.Athlete_IDcomboBox.Location = new System.Drawing.Point(299, 376);
            this.Athlete_IDcomboBox.Name = "Athlete_IDcomboBox";
            this.Athlete_IDcomboBox.Size = new System.Drawing.Size(274, 28);
            this.Athlete_IDcomboBox.TabIndex = 9;
            this.Athlete_IDcomboBox.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // Coach_IDcomboBox
            // 
            this.Coach_IDcomboBox.FormattingEnabled = true;
            this.Coach_IDcomboBox.Location = new System.Drawing.Point(299, 483);
            this.Coach_IDcomboBox.Name = "Coach_IDcomboBox";
            this.Coach_IDcomboBox.Size = new System.Drawing.Size(274, 28);
            this.Coach_IDcomboBox.TabIndex = 10;
            // 
            // Ath_pri_coachingdataGridView
            // 
            this.Ath_pri_coachingdataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Ath_pri_coachingdataGridView.Location = new System.Drawing.Point(84, 641);
            this.Ath_pri_coachingdataGridView.Name = "Ath_pri_coachingdataGridView";
            this.Ath_pri_coachingdataGridView.RowHeadersWidth = 62;
            this.Ath_pri_coachingdataGridView.RowTemplate.Height = 28;
            this.Ath_pri_coachingdataGridView.Size = new System.Drawing.Size(667, 209);
            this.Ath_pri_coachingdataGridView.TabIndex = 11;
            // 
            // Starting_DatedateTimePicker
            // 
            this.Starting_DatedateTimePicker.Location = new System.Drawing.Point(299, 217);
            this.Starting_DatedateTimePicker.Name = "Starting_DatedateTimePicker";
            this.Starting_DatedateTimePicker.Size = new System.Drawing.Size(270, 26);
            this.Starting_DatedateTimePicker.TabIndex = 12;
            // 
            // Ending_DatedateTimePicker
            // 
            this.Ending_DatedateTimePicker.Location = new System.Drawing.Point(299, 303);
            this.Ending_DatedateTimePicker.Name = "Ending_DatedateTimePicker";
            this.Ending_DatedateTimePicker.Size = new System.Drawing.Size(274, 26);
            this.Ending_DatedateTimePicker.TabIndex = 13;
            // 
            // ClearBtn
            // 
            this.ClearBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClearBtn.Location = new System.Drawing.Point(631, 458);
            this.ClearBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ClearBtn.Name = "ClearBtn";
            this.ClearBtn.Size = new System.Drawing.Size(159, 55);
            this.ClearBtn.TabIndex = 117;
            this.ClearBtn.Text = "Clear";
            this.ClearBtn.UseVisualStyleBackColor = true;
            this.ClearBtn.Click += new System.EventHandler(this.ClearBtn_Click);
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteBtn.Location = new System.Drawing.Point(631, 360);
            this.DeleteBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(159, 55);
            this.DeleteBtn.TabIndex = 116;
            this.DeleteBtn.Text = "Delete";
            this.DeleteBtn.UseVisualStyleBackColor = true;
            this.DeleteBtn.Click += new System.EventHandler(this.DeleteBtn_Click);
            // 
            // UpdateBtn
            // 
            this.UpdateBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdateBtn.Location = new System.Drawing.Point(631, 260);
            this.UpdateBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.UpdateBtn.Name = "UpdateBtn";
            this.UpdateBtn.Size = new System.Drawing.Size(159, 55);
            this.UpdateBtn.TabIndex = 115;
            this.UpdateBtn.Text = "Update";
            this.UpdateBtn.UseVisualStyleBackColor = true;
            this.UpdateBtn.Click += new System.EventHandler(this.UpdateBtn_Click);
            // 
            // SaveBtn
            // 
            this.SaveBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveBtn.Location = new System.Drawing.Point(631, 164);
            this.SaveBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(159, 55);
            this.SaveBtn.TabIndex = 114;
            this.SaveBtn.Text = "Save";
            this.SaveBtn.UseVisualStyleBackColor = true;
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // closeBtn
            // 
            this.closeBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeBtn.Location = new System.Drawing.Point(730, 25);
            this.closeBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(43, 46);
            this.closeBtn.TabIndex = 118;
            this.closeBtn.Text = "X";
            this.closeBtn.UseVisualStyleBackColor = true;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // DashboardBtn
            // 
            this.DashboardBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DashboardBtn.Location = new System.Drawing.Point(631, 541);
            this.DashboardBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.DashboardBtn.Name = "DashboardBtn";
            this.DashboardBtn.Size = new System.Drawing.Size(159, 55);
            this.DashboardBtn.TabIndex = 119;
            this.DashboardBtn.Text = "Dashboard";
            this.DashboardBtn.UseVisualStyleBackColor = true;
            this.DashboardBtn.Click += new System.EventHandler(this.DashboardBtn_Click);
            // 
            // Ath_pri_coaching
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Judo.Properties.Resources.judo_edited;
            this.ClientSize = new System.Drawing.Size(800, 900);
            this.Controls.Add(this.DashboardBtn);
            this.Controls.Add(this.closeBtn);
            this.Controls.Add(this.ClearBtn);
            this.Controls.Add(this.DeleteBtn);
            this.Controls.Add(this.UpdateBtn);
            this.Controls.Add(this.SaveBtn);
            this.Controls.Add(this.Ending_DatedateTimePicker);
            this.Controls.Add(this.Starting_DatedateTimePicker);
            this.Controls.Add(this.Ath_pri_coachingdataGridView);
            this.Controls.Add(this.Coach_IDcomboBox);
            this.Controls.Add(this.Athlete_IDcomboBox);
            this.Controls.Add(this.Ath_pri_coach_IDtextBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Ath_pri_coaching";
            this.Text = "Ath_pri_coaching";
            this.Load += new System.EventHandler(this.Ath_pri_coaching_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Ath_pri_coachingdataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox Ath_pri_coach_IDtextBox;
        private System.Windows.Forms.ComboBox Athlete_IDcomboBox;
        private System.Windows.Forms.ComboBox Coach_IDcomboBox;
        private System.Windows.Forms.DataGridView Ath_pri_coachingdataGridView;
        private System.Windows.Forms.DateTimePicker Starting_DatedateTimePicker;
        private System.Windows.Forms.DateTimePicker Ending_DatedateTimePicker;
        private System.Windows.Forms.Button ClearBtn;
        private System.Windows.Forms.Button DeleteBtn;
        private System.Windows.Forms.Button UpdateBtn;
        private System.Windows.Forms.Button SaveBtn;
        private System.Windows.Forms.Button closeBtn;
        private System.Windows.Forms.Button DashboardBtn;
    }
}