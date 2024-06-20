namespace VotingWorkshopManagement
{
    partial class RequestTab
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
            lblSaloon = new System.Windows.Forms.Label();
            comboSaloon = new System.Windows.Forms.ComboBox();
            comboCategory = new System.Windows.Forms.ComboBox();
            label1 = new System.Windows.Forms.Label();
            comboTimeslot = new System.Windows.Forms.ComboBox();
            lblTimeslot = new System.Windows.Forms.Label();
            lblDate = new System.Windows.Forms.Label();
            datePicker = new System.Windows.Forms.DateTimePicker();
            btnConfirm = new System.Windows.Forms.Button();
            lblTitle = new System.Windows.Forms.Label();
            SuspendLayout();
            // 
            // lblSaloon
            // 
            lblSaloon.AutoSize = true;
            lblSaloon.Location = new System.Drawing.Point(412, 183);
            lblSaloon.Name = "lblSaloon";
            lblSaloon.Size = new System.Drawing.Size(67, 25);
            lblSaloon.TabIndex = 0;
            lblSaloon.Text = "Saloon";
            // 
            // comboSaloon
            // 
            comboSaloon.FormattingEnabled = true;
            comboSaloon.Location = new System.Drawing.Point(412, 211);
            comboSaloon.Name = "comboSaloon";
            comboSaloon.Size = new System.Drawing.Size(182, 33);
            comboSaloon.TabIndex = 1;
            // 
            // comboCategory
            // 
            comboCategory.FormattingEnabled = true;
            comboCategory.Location = new System.Drawing.Point(668, 211);
            comboCategory.Name = "comboCategory";
            comboCategory.Size = new System.Drawing.Size(182, 33);
            comboCategory.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(668, 183);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(84, 25);
            label1.TabIndex = 2;
            label1.Text = "Category";
            // 
            // comboTimeslot
            // 
            comboTimeslot.FormattingEnabled = true;
            comboTimeslot.Location = new System.Drawing.Point(412, 314);
            comboTimeslot.Name = "comboTimeslot";
            comboTimeslot.Size = new System.Drawing.Size(182, 33);
            comboTimeslot.TabIndex = 5;
            // 
            // lblTimeslot
            // 
            lblTimeslot.AutoSize = true;
            lblTimeslot.Location = new System.Drawing.Point(412, 286);
            lblTimeslot.Name = "lblTimeslot";
            lblTimeslot.Size = new System.Drawing.Size(79, 25);
            lblTimeslot.TabIndex = 4;
            lblTimeslot.Text = "Timeslot";
            // 
            // lblDate
            // 
            lblDate.AutoSize = true;
            lblDate.Location = new System.Drawing.Point(668, 286);
            lblDate.Name = "lblDate";
            lblDate.Size = new System.Drawing.Size(49, 25);
            lblDate.TabIndex = 6;
            lblDate.Text = "Date";
            // 
            // datePicker
            // 
            datePicker.Location = new System.Drawing.Point(668, 314);
            datePicker.Name = "datePicker";
            datePicker.Size = new System.Drawing.Size(300, 31);
            datePicker.TabIndex = 7;
            // 
            // btnConfirm
            // 
            btnConfirm.BackColor = System.Drawing.Color.DarkSeaGreen;
            btnConfirm.FlatAppearance.BorderSize = 0;
            btnConfirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnConfirm.Location = new System.Drawing.Point(564, 446);
            btnConfirm.Name = "btnConfirm";
            btnConfirm.Size = new System.Drawing.Size(129, 63);
            btnConfirm.TabIndex = 29;
            btnConfirm.Text = "Confirm";
            btnConfirm.UseVisualStyleBackColor = false;
            btnConfirm.Click += btnConfirm_Click;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblTitle.Location = new System.Drawing.Point(511, 77);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new System.Drawing.Size(228, 32);
            lblTitle.TabIndex = 27;
            lblTitle.Text = "Request Workshop";
            // 
            // RequestTab
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1258, 644);
            Controls.Add(btnConfirm);
            Controls.Add(lblTitle);
            Controls.Add(datePicker);
            Controls.Add(lblDate);
            Controls.Add(comboTimeslot);
            Controls.Add(lblTimeslot);
            Controls.Add(comboCategory);
            Controls.Add(label1);
            Controls.Add(comboSaloon);
            Controls.Add(lblSaloon);
            Name = "RequestTab";
            Text = "RequestTab";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblSaloon;
        private System.Windows.Forms.ComboBox comboSaloon;
        private System.Windows.Forms.ComboBox comboCategory;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboTimeslot;
        private System.Windows.Forms.Label lblTimeslot;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.DateTimePicker datePicker;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Label lblTitle;
    }
}