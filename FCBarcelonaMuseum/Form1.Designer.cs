namespace FCBarcelonaMuseum
{
    partial class Form1
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
            this.labelMuseumName = new System.Windows.Forms.Label();
            this.groupBoxNewVisitor = new System.Windows.Forms.GroupBox();
            this.labelGender = new System.Windows.Forms.Label();
            this.grpGender = new System.Windows.Forms.GroupBox();
            this.radMale = new System.Windows.Forms.RadioButton();
            this.radFemale = new System.Windows.Forms.RadioButton();
            this.btnSave = new System.Windows.Forms.Button();
            this.cmbOccupation = new System.Windows.Forms.ComboBox();
            this.txtPhNo = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.labelPhNo = new System.Windows.Forms.Label();
            this.labelOccupation = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.dataGridTable = new System.Windows.Forms.DataGridView();
            this.ColnCardNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColnFullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColnPhNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColnOccupation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColnGender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColnInTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColnOutTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColnDay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelCardNo = new System.Windows.Forms.Label();
            this.txtCardNo = new System.Windows.Forms.TextBox();
            this.btnClearAll = new System.Windows.Forms.Button();
            this.btnCheckIn = new System.Windows.Forms.Button();
            this.groupBoxNewVisitor.SuspendLayout();
            this.grpGender.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridTable)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelMuseumName
            // 
            this.labelMuseumName.Font = new System.Drawing.Font("Century Gothic", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMuseumName.Location = new System.Drawing.Point(589, 27);
            this.labelMuseumName.Name = "labelMuseumName";
            this.labelMuseumName.Size = new System.Drawing.Size(400, 50);
            this.labelMuseumName.TabIndex = 1;
            this.labelMuseumName.Text = "FC BARCELONA";
            // 
            // groupBoxNewVisitor
            // 
            this.groupBoxNewVisitor.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBoxNewVisitor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.groupBoxNewVisitor.Controls.Add(this.btnClearAll);
            this.groupBoxNewVisitor.Controls.Add(this.labelGender);
            this.groupBoxNewVisitor.Controls.Add(this.grpGender);
            this.groupBoxNewVisitor.Controls.Add(this.btnSave);
            this.groupBoxNewVisitor.Controls.Add(this.cmbOccupation);
            this.groupBoxNewVisitor.Controls.Add(this.txtPhNo);
            this.groupBoxNewVisitor.Controls.Add(this.txtName);
            this.groupBoxNewVisitor.Controls.Add(this.labelPhNo);
            this.groupBoxNewVisitor.Controls.Add(this.labelOccupation);
            this.groupBoxNewVisitor.Controls.Add(this.labelName);
            this.groupBoxNewVisitor.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxNewVisitor.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.groupBoxNewVisitor.Location = new System.Drawing.Point(19, 76);
            this.groupBoxNewVisitor.Name = "groupBoxNewVisitor";
            this.groupBoxNewVisitor.Size = new System.Drawing.Size(547, 396);
            this.groupBoxNewVisitor.TabIndex = 15;
            this.groupBoxNewVisitor.TabStop = false;
            this.groupBoxNewVisitor.Text = "Visitor\'s data";
            // 
            // labelGender
            // 
            this.labelGender.AutoSize = true;
            this.labelGender.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGender.Location = new System.Drawing.Point(17, 251);
            this.labelGender.Name = "labelGender";
            this.labelGender.Size = new System.Drawing.Size(82, 23);
            this.labelGender.TabIndex = 28;
            this.labelGender.Text = "Gender:";
            // 
            // grpGender
            // 
            this.grpGender.Controls.Add(this.radMale);
            this.grpGender.Controls.Add(this.radFemale);
            this.grpGender.Location = new System.Drawing.Point(245, 227);
            this.grpGender.Name = "grpGender";
            this.grpGender.Size = new System.Drawing.Size(280, 59);
            this.grpGender.TabIndex = 27;
            this.grpGender.TabStop = false;
            // 
            // radMale
            // 
            this.radMale.AutoSize = true;
            this.radMale.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radMale.Location = new System.Drawing.Point(6, 21);
            this.radMale.Name = "radMale";
            this.radMale.Size = new System.Drawing.Size(64, 26);
            this.radMale.TabIndex = 23;
            this.radMale.TabStop = true;
            this.radMale.Text = "Male";
            this.radMale.UseVisualStyleBackColor = true;
            // 
            // radFemale
            // 
            this.radFemale.AutoSize = true;
            this.radFemale.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radFemale.Location = new System.Drawing.Point(170, 21);
            this.radFemale.Name = "radFemale";
            this.radFemale.Size = new System.Drawing.Size(80, 26);
            this.radFemale.TabIndex = 24;
            this.radFemale.TabStop = true;
            this.radFemale.Text = "Female";
            this.radFemale.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(68, 326);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(139, 35);
            this.btnSave.TabIndex = 25;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // cmbOccupation
            // 
            this.cmbOccupation.FormattingEnabled = true;
            this.cmbOccupation.Items.AddRange(new object[] {
            "Doctor",
            "Pilot",
            "Engineer",
            "Teacher",
            "IT Professional ",
            "Accountant",
            "Athlete",
            "Politician"});
            this.cmbOccupation.Location = new System.Drawing.Point(245, 178);
            this.cmbOccupation.Name = "cmbOccupation";
            this.cmbOccupation.Size = new System.Drawing.Size(280, 35);
            this.cmbOccupation.TabIndex = 21;
            // 
            // txtPhNo
            // 
            this.txtPhNo.Location = new System.Drawing.Point(245, 113);
            this.txtPhNo.Name = "txtPhNo";
            this.txtPhNo.Size = new System.Drawing.Size(280, 36);
            this.txtPhNo.TabIndex = 20;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(245, 48);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(280, 36);
            this.txtName.TabIndex = 18;
            // 
            // labelPhNo
            // 
            this.labelPhNo.AutoSize = true;
            this.labelPhNo.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPhNo.Location = new System.Drawing.Point(17, 116);
            this.labelPhNo.Name = "labelPhNo";
            this.labelPhNo.Size = new System.Drawing.Size(107, 23);
            this.labelPhNo.TabIndex = 17;
            this.labelPhNo.Text = "Phone No.:";
            // 
            // labelOccupation
            // 
            this.labelOccupation.AutoSize = true;
            this.labelOccupation.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelOccupation.Location = new System.Drawing.Point(17, 181);
            this.labelOccupation.Name = "labelOccupation";
            this.labelOccupation.Size = new System.Drawing.Size(115, 23);
            this.labelOccupation.TabIndex = 15;
            this.labelOccupation.Text = "Occupation:";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelName.Location = new System.Drawing.Point(17, 48);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(67, 23);
            this.labelName.TabIndex = 14;
            this.labelName.Text = "Name:";
            // 
            // dataGridTable
            // 
            this.dataGridTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridTable.BackgroundColor = System.Drawing.SystemColors.ButtonShadow;
            this.dataGridTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColnCardNum,
            this.ColnFullName,
            this.ColnPhNum,
            this.ColnOccupation,
            this.ColnGender,
            this.ColnInTime,
            this.ColnOutTime,
            this.ColnDay});
            this.dataGridTable.Location = new System.Drawing.Point(597, 91);
            this.dataGridTable.Name = "dataGridTable";
            this.dataGridTable.RowTemplate.Height = 24;
            this.dataGridTable.Size = new System.Drawing.Size(846, 597);
            this.dataGridTable.TabIndex = 29;
            // 
            // ColnCardNum
            // 
            this.ColnCardNum.HeaderText = "Card No.";
            this.ColnCardNum.Name = "ColnCardNum";
            // 
            // ColnFullName
            // 
            this.ColnFullName.HeaderText = "Full Name";
            this.ColnFullName.Name = "ColnFullName";
            // 
            // ColnPhNum
            // 
            this.ColnPhNum.HeaderText = "Phone No.";
            this.ColnPhNum.Name = "ColnPhNum";
            // 
            // ColnOccupation
            // 
            this.ColnOccupation.HeaderText = "Occupation";
            this.ColnOccupation.Name = "ColnOccupation";
            // 
            // ColnGender
            // 
            this.ColnGender.HeaderText = "Gender";
            this.ColnGender.Name = "ColnGender";
            // 
            // ColnInTime
            // 
            this.ColnInTime.HeaderText = "InTime";
            this.ColnInTime.Name = "ColnInTime";
            // 
            // ColnOutTime
            // 
            this.ColnOutTime.HeaderText = "Out Time";
            this.ColnOutTime.Name = "ColnOutTime";
            // 
            // ColnDay
            // 
            this.ColnDay.HeaderText = "Day";
            this.ColnDay.Name = "ColnDay";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnCheckIn);
            this.groupBox1.Controls.Add(this.txtCardNo);
            this.groupBox1.Controls.Add(this.labelCardNo);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.groupBox1.Location = new System.Drawing.Point(19, 501);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(547, 187);
            this.groupBox1.TabIndex = 30;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Old Visitor";
            // 
            // labelCardNo
            // 
            this.labelCardNo.AutoSize = true;
            this.labelCardNo.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCardNo.Location = new System.Drawing.Point(17, 62);
            this.labelCardNo.Name = "labelCardNo";
            this.labelCardNo.Size = new System.Drawing.Size(89, 23);
            this.labelCardNo.TabIndex = 0;
            this.labelCardNo.Text = "Card No.";
            // 
            // txtCardNo
            // 
            this.txtCardNo.Location = new System.Drawing.Point(204, 59);
            this.txtCardNo.Name = "txtCardNo";
            this.txtCardNo.Size = new System.Drawing.Size(280, 36);
            this.txtCardNo.TabIndex = 29;
            // 
            // btnClearAll
            // 
            this.btnClearAll.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearAll.Location = new System.Drawing.Point(281, 326);
            this.btnClearAll.Name = "btnClearAll";
            this.btnClearAll.Size = new System.Drawing.Size(139, 35);
            this.btnClearAll.TabIndex = 29;
            this.btnClearAll.Text = "Clear All";
            this.btnClearAll.UseVisualStyleBackColor = true;
            // 
            // btnCheckIn
            // 
            this.btnCheckIn.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheckIn.Location = new System.Drawing.Point(176, 126);
            this.btnCheckIn.Name = "btnCheckIn";
            this.btnCheckIn.Size = new System.Drawing.Size(139, 35);
            this.btnCheckIn.TabIndex = 30;
            this.btnCheckIn.Text = "Check In";
            this.btnCheckIn.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1471, 725);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridTable);
            this.Controls.Add(this.groupBoxNewVisitor);
            this.Controls.Add(this.labelMuseumName);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBoxNewVisitor.ResumeLayout(false);
            this.groupBoxNewVisitor.PerformLayout();
            this.grpGender.ResumeLayout(false);
            this.grpGender.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridTable)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label labelMuseumName;
        private System.Windows.Forms.GroupBox groupBoxNewVisitor;
        private System.Windows.Forms.Label labelGender;
        private System.Windows.Forms.GroupBox grpGender;
        private System.Windows.Forms.RadioButton radMale;
        private System.Windows.Forms.RadioButton radFemale;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ComboBox cmbOccupation;
        private System.Windows.Forms.TextBox txtPhNo;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label labelPhNo;
        private System.Windows.Forms.Label labelOccupation;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.DataGridView dataGridTable;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColnCardNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColnFullName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColnPhNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColnOccupation;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColnGender;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColnInTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColnOutTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColnDay;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtCardNo;
        private System.Windows.Forms.Label labelCardNo;
        private System.Windows.Forms.Button btnClearAll;
        private System.Windows.Forms.Button btnCheckIn;
    }
}

