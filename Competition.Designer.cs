namespace Judo
{
    partial class Competition
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
            this.Competition_IDtextBox = new System.Windows.Forms.TextBox();
            this.Entry_FeetextBox = new System.Windows.Forms.TextBox();
            this.Category_IDcomboBox = new System.Windows.Forms.ComboBox();
            this.CompetitiondataGridView = new System.Windows.Forms.DataGridView();
            this.Competition_DatedateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.Competition_NametextBox = new System.Windows.Forms.TextBox();
            this.ClearBtn = new System.Windows.Forms.Button();
            this.DeleteBtn = new System.Windows.Forms.Button();
            this.UpdateBtn = new System.Windows.Forms.Button();
            this.SaveBtn = new System.Windows.Forms.Button();
            this.closeBtn = new System.Windows.Forms.Button();
            this.DashboardBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.CompetitiondataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(254, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(245, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "Competition";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(68, 160);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(177, 26);
            this.label2.TabIndex = 1;
            this.label2.Text = "Competition_ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(68, 342);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(203, 26);
            this.label3.TabIndex = 2;
            this.label3.Text = "Competition_Date";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(73, 424);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label4.Size = new System.Drawing.Size(121, 26);
            this.label4.TabIndex = 3;
            this.label4.Text = "Entry_Fee";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(68, 512);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(145, 26);
            this.label5.TabIndex = 4;
            this.label5.Text = "Category_ID";
            // 
            // Competition_IDtextBox
            // 
            this.Competition_IDtextBox.Location = new System.Drawing.Point(303, 160);
            this.Competition_IDtextBox.Name = "Competition_IDtextBox";
            this.Competition_IDtextBox.ReadOnly = true;
            this.Competition_IDtextBox.Size = new System.Drawing.Size(293, 26);
            this.Competition_IDtextBox.TabIndex = 5;
            // 
            // Entry_FeetextBox
            // 
            this.Entry_FeetextBox.Location = new System.Drawing.Point(303, 424);
            this.Entry_FeetextBox.Name = "Entry_FeetextBox";
            this.Entry_FeetextBox.Size = new System.Drawing.Size(293, 26);
            this.Entry_FeetextBox.TabIndex = 7;
            this.Entry_FeetextBox.TextChanged += new System.EventHandler(this.Entry_FeetextBox_TextChanged);
            // 
            // Category_IDcomboBox
            // 
            this.Category_IDcomboBox.FormattingEnabled = true;
            this.Category_IDcomboBox.Location = new System.Drawing.Point(303, 510);
            this.Category_IDcomboBox.Name = "Category_IDcomboBox";
            this.Category_IDcomboBox.Size = new System.Drawing.Size(293, 28);
            this.Category_IDcomboBox.TabIndex = 8;
            // 
            // CompetitiondataGridView
            // 
            this.CompetitiondataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CompetitiondataGridView.Location = new System.Drawing.Point(78, 612);
            this.CompetitiondataGridView.Name = "CompetitiondataGridView";
            this.CompetitiondataGridView.RowHeadersWidth = 62;
            this.CompetitiondataGridView.RowTemplate.Height = 28;
            this.CompetitiondataGridView.Size = new System.Drawing.Size(682, 231);
            this.CompetitiondataGridView.TabIndex = 9;
            // 
            // Competition_DatedateTimePicker
            // 
            this.Competition_DatedateTimePicker.Location = new System.Drawing.Point(303, 342);
            this.Competition_DatedateTimePicker.Name = "Competition_DatedateTimePicker";
            this.Competition_DatedateTimePicker.Size = new System.Drawing.Size(293, 26);
            this.Competition_DatedateTimePicker.TabIndex = 10;
            this.Competition_DatedateTimePicker.ValueChanged += new System.EventHandler(this.Competition_DatedateTimePicker_ValueChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(68, 261);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(216, 26);
            this.label6.TabIndex = 11;
            this.label6.Text = "Competition_Name";
            // 
            // Competition_NametextBox
            // 
            this.Competition_NametextBox.Location = new System.Drawing.Point(303, 261);
            this.Competition_NametextBox.Name = "Competition_NametextBox";
            this.Competition_NametextBox.Size = new System.Drawing.Size(293, 26);
            this.Competition_NametextBox.TabIndex = 12;
            // 
            // ClearBtn
            // 
            this.ClearBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClearBtn.Location = new System.Drawing.Point(613, 464);
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
            this.DeleteBtn.Location = new System.Drawing.Point(613, 381);
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
            this.UpdateBtn.Location = new System.Drawing.Point(613, 281);
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
            this.SaveBtn.Location = new System.Drawing.Point(613, 185);
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
            this.closeBtn.Location = new System.Drawing.Point(745, 24);
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
            this.DashboardBtn.Location = new System.Drawing.Point(613, 550);
            this.DashboardBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.DashboardBtn.Name = "DashboardBtn";
            this.DashboardBtn.Size = new System.Drawing.Size(159, 55);
            this.DashboardBtn.TabIndex = 119;
            this.DashboardBtn.Text = "Dashboard";
            this.DashboardBtn.UseVisualStyleBackColor = true;
            this.DashboardBtn.Click += new System.EventHandler(this.DashboardBtn_Click);
            // 
            // Competition
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
            this.Controls.Add(this.Competition_NametextBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Competition_DatedateTimePicker);
            this.Controls.Add(this.CompetitiondataGridView);
            this.Controls.Add(this.Category_IDcomboBox);
            this.Controls.Add(this.Entry_FeetextBox);
            this.Controls.Add(this.Competition_IDtextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Competition";
            this.Text = "Competition";
            this.Load += new System.EventHandler(this.Competition_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CompetitiondataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Competition_IDtextBox;
        private System.Windows.Forms.TextBox Entry_FeetextBox;
        private System.Windows.Forms.ComboBox Category_IDcomboBox;
        private System.Windows.Forms.DataGridView CompetitiondataGridView;
        private System.Windows.Forms.DateTimePicker Competition_DatedateTimePicker;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox Competition_NametextBox;
        private System.Windows.Forms.Button ClearBtn;
        private System.Windows.Forms.Button DeleteBtn;
        private System.Windows.Forms.Button UpdateBtn;
        private System.Windows.Forms.Button SaveBtn;
        private System.Windows.Forms.Button closeBtn;
        private System.Windows.Forms.Button DashboardBtn;
    }
}