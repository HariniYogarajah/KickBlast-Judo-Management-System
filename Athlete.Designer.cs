namespace Judo
{
    partial class Athlete
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
            this.Athlete_IDtextBox = new System.Windows.Forms.TextBox();
            this.Ath_NametextBox = new System.Windows.Forms.TextBox();
            this.AgetextBox = new System.Windows.Forms.TextBox();
            this.ContacttextBox = new System.Windows.Forms.TextBox();
            this.Curr_WeighttextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.Admin_IDcomboBox = new System.Windows.Forms.ComboBox();
            this.Category_IDcomboBox = new System.Windows.Forms.ComboBox();
            this.Plan_IDcomboBox = new System.Windows.Forms.ComboBox();
            this.AthletedataGridView = new System.Windows.Forms.DataGridView();
            this.ClearBtn = new System.Windows.Forms.Button();
            this.DeleteBtn = new System.Windows.Forms.Button();
            this.UpdateBtn = new System.Windows.Forms.Button();
            this.SaveBtn = new System.Windows.Forms.Button();
            this.closeBtn = new System.Windows.Forms.Button();
            this.DashboardBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.AthletedataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(310, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "Athlete";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(92, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 26);
            this.label2.TabIndex = 1;
            this.label2.Text = "Athlete_ID";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(92, 211);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 26);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ath_Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(92, 272);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 26);
            this.label4.TabIndex = 3;
            this.label4.Text = "Age";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(92, 338);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 26);
            this.label5.TabIndex = 4;
            this.label5.Text = "Contact";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(92, 401);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(145, 26);
            this.label6.TabIndex = 5;
            this.label6.Text = "Curr_Weight";
            // 
            // Athlete_IDtextBox
            // 
            this.Athlete_IDtextBox.Location = new System.Drawing.Point(263, 133);
            this.Athlete_IDtextBox.Name = "Athlete_IDtextBox";
            this.Athlete_IDtextBox.ReadOnly = true;
            this.Athlete_IDtextBox.Size = new System.Drawing.Size(253, 26);
            this.Athlete_IDtextBox.TabIndex = 6;
            // 
            // Ath_NametextBox
            // 
            this.Ath_NametextBox.Location = new System.Drawing.Point(263, 208);
            this.Ath_NametextBox.Name = "Ath_NametextBox";
            this.Ath_NametextBox.Size = new System.Drawing.Size(253, 26);
            this.Ath_NametextBox.TabIndex = 7;
            // 
            // AgetextBox
            // 
            this.AgetextBox.Location = new System.Drawing.Point(263, 267);
            this.AgetextBox.Name = "AgetextBox";
            this.AgetextBox.Size = new System.Drawing.Size(253, 26);
            this.AgetextBox.TabIndex = 8;
            // 
            // ContacttextBox
            // 
            this.ContacttextBox.Location = new System.Drawing.Point(263, 331);
            this.ContacttextBox.Name = "ContacttextBox";
            this.ContacttextBox.Size = new System.Drawing.Size(253, 26);
            this.ContacttextBox.TabIndex = 9;
            // 
            // Curr_WeighttextBox
            // 
            this.Curr_WeighttextBox.Location = new System.Drawing.Point(263, 401);
            this.Curr_WeighttextBox.Name = "Curr_WeighttextBox";
            this.Curr_WeighttextBox.Size = new System.Drawing.Size(253, 26);
            this.Curr_WeighttextBox.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(92, 482);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(117, 26);
            this.label7.TabIndex = 11;
            this.label7.Text = "Admin_ID";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(92, 553);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(145, 26);
            this.label8.TabIndex = 12;
            this.label8.Text = "Category_ID";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(92, 622);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(97, 26);
            this.label9.TabIndex = 13;
            this.label9.Text = "Plan_ID";
            // 
            // Admin_IDcomboBox
            // 
            this.Admin_IDcomboBox.FormattingEnabled = true;
            this.Admin_IDcomboBox.Location = new System.Drawing.Point(263, 482);
            this.Admin_IDcomboBox.Name = "Admin_IDcomboBox";
            this.Admin_IDcomboBox.Size = new System.Drawing.Size(253, 28);
            this.Admin_IDcomboBox.TabIndex = 14;
            // 
            // Category_IDcomboBox
            // 
            this.Category_IDcomboBox.FormattingEnabled = true;
            this.Category_IDcomboBox.Location = new System.Drawing.Point(263, 545);
            this.Category_IDcomboBox.Name = "Category_IDcomboBox";
            this.Category_IDcomboBox.Size = new System.Drawing.Size(253, 28);
            this.Category_IDcomboBox.TabIndex = 15;
            // 
            // Plan_IDcomboBox
            // 
            this.Plan_IDcomboBox.FormattingEnabled = true;
            this.Plan_IDcomboBox.Location = new System.Drawing.Point(263, 614);
            this.Plan_IDcomboBox.Name = "Plan_IDcomboBox";
            this.Plan_IDcomboBox.Size = new System.Drawing.Size(253, 28);
            this.Plan_IDcomboBox.TabIndex = 16;
            // 
            // AthletedataGridView
            // 
            this.AthletedataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AthletedataGridView.Location = new System.Drawing.Point(71, 693);
            this.AthletedataGridView.Name = "AthletedataGridView";
            this.AthletedataGridView.RowHeadersWidth = 62;
            this.AthletedataGridView.RowTemplate.Height = 28;
            this.AthletedataGridView.Size = new System.Drawing.Size(678, 195);
            this.AthletedataGridView.TabIndex = 17;
            this.AthletedataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // ClearBtn
            // 
            this.ClearBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClearBtn.Location = new System.Drawing.Point(584, 482);
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
            this.DeleteBtn.Location = new System.Drawing.Point(584, 385);
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
            this.UpdateBtn.Location = new System.Drawing.Point(584, 289);
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
            this.SaveBtn.Location = new System.Drawing.Point(584, 192);
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
            this.closeBtn.Location = new System.Drawing.Point(734, 13);
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
            this.DashboardBtn.Location = new System.Drawing.Point(584, 587);
            this.DashboardBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.DashboardBtn.Name = "DashboardBtn";
            this.DashboardBtn.Size = new System.Drawing.Size(159, 55);
            this.DashboardBtn.TabIndex = 119;
            this.DashboardBtn.Text = "Dashboard";
            this.DashboardBtn.UseVisualStyleBackColor = true;
            this.DashboardBtn.Click += new System.EventHandler(this.DashboardBtn_Click);
            // 
            // Athlete
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
            this.Controls.Add(this.AthletedataGridView);
            this.Controls.Add(this.Plan_IDcomboBox);
            this.Controls.Add(this.Category_IDcomboBox);
            this.Controls.Add(this.Admin_IDcomboBox);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.Curr_WeighttextBox);
            this.Controls.Add(this.ContacttextBox);
            this.Controls.Add(this.AgetextBox);
            this.Controls.Add(this.Ath_NametextBox);
            this.Controls.Add(this.Athlete_IDtextBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Athlete";
            this.Text = "Athlete";
            this.Load += new System.EventHandler(this.Athlete_Load);
            ((System.ComponentModel.ISupportInitialize)(this.AthletedataGridView)).EndInit();
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
        private System.Windows.Forms.TextBox Athlete_IDtextBox;
        private System.Windows.Forms.TextBox Ath_NametextBox;
        private System.Windows.Forms.TextBox AgetextBox;
        private System.Windows.Forms.TextBox ContacttextBox;
        private System.Windows.Forms.TextBox Curr_WeighttextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox Admin_IDcomboBox;
        private System.Windows.Forms.ComboBox Category_IDcomboBox;
        private System.Windows.Forms.ComboBox Plan_IDcomboBox;
        private System.Windows.Forms.DataGridView AthletedataGridView;
        private System.Windows.Forms.Button ClearBtn;
        private System.Windows.Forms.Button DeleteBtn;
        private System.Windows.Forms.Button UpdateBtn;
        private System.Windows.Forms.Button SaveBtn;
        private System.Windows.Forms.Button closeBtn;
        private System.Windows.Forms.Button DashboardBtn;
    }
}