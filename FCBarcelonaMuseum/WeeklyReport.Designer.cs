namespace FCBarcelonaMuseum
{
    partial class WeeklyReport
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ColnDayReport = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColnTotalVisitors = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labelWeekPicker = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColnDayReport,
            this.ColnTotalVisitors});
            this.dataGridView1.Location = new System.Drawing.Point(62, 134);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(438, 337);
            this.dataGridView1.TabIndex = 0;
            // 
            // ColnDayReport
            // 
            this.ColnDayReport.HeaderText = "Day";
            this.ColnDayReport.Name = "ColnDayReport";
            // 
            // ColnTotalVisitors
            // 
            this.ColnTotalVisitors.HeaderText = "Total Visitors";
            this.ColnTotalVisitors.Name = "ColnTotalVisitors";
            // 
            // labelWeekPicker
            // 
            this.labelWeekPicker.AutoSize = true;
            this.labelWeekPicker.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWeekPicker.Location = new System.Drawing.Point(106, 82);
            this.labelWeekPicker.Name = "labelWeekPicker";
            this.labelWeekPicker.Size = new System.Drawing.Size(128, 23);
            this.labelWeekPicker.TabIndex = 1;
            this.labelWeekPicker.Text = "Week Picker:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(282, 81);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(180, 24);
            this.comboBox1.TabIndex = 2;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // WeeklyReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1167, 578);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.labelWeekPicker);
            this.Controls.Add(this.dataGridView1);
            this.Name = "WeeklyReport";
            this.Text = "WeeklyReport";
            this.Load += new System.EventHandler(this.WeeklyReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColnDayReport;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColnTotalVisitors;
        private System.Windows.Forms.Label labelWeekPicker;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}