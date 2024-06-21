namespace VotingWorkshopManagement.Popups
{
    partial class VoteSurvey
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
            lblOptions = new System.Windows.Forms.Label();
            lblQuestion = new System.Windows.Forms.Label();
            btnConfirm = new System.Windows.Forms.Button();
            btnCancel = new System.Windows.Forms.Button();
            lblTitle = new System.Windows.Forms.Label();
            lblName = new System.Windows.Forms.Label();
            txtName = new System.Windows.Forms.Label();
            txtQuestion = new System.Windows.Forms.Label();
            comboOptions = new System.Windows.Forms.ComboBox();
            SuspendLayout();
            // 
            // lblOptions
            // 
            lblOptions.AutoSize = true;
            lblOptions.Location = new System.Drawing.Point(390, 92);
            lblOptions.Name = "lblOptions";
            lblOptions.Size = new System.Drawing.Size(76, 25);
            lblOptions.TabIndex = 48;
            lblOptions.Text = "Options";
            // 
            // lblQuestion
            // 
            lblQuestion.AutoSize = true;
            lblQuestion.Location = new System.Drawing.Point(103, 125);
            lblQuestion.Name = "lblQuestion";
            lblQuestion.Size = new System.Drawing.Size(84, 25);
            lblQuestion.TabIndex = 42;
            lblQuestion.Text = "Question";
            // 
            // btnConfirm
            // 
            btnConfirm.BackColor = System.Drawing.Color.DarkSeaGreen;
            btnConfirm.FlatAppearance.BorderSize = 0;
            btnConfirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnConfirm.Location = new System.Drawing.Point(421, 355);
            btnConfirm.Name = "btnConfirm";
            btnConfirm.Size = new System.Drawing.Size(129, 63);
            btnConfirm.TabIndex = 41;
            btnConfirm.Text = "Confirm";
            btnConfirm.UseVisualStyleBackColor = false;
            btnConfirm.Click += btnConfirm_Click;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = System.Drawing.Color.LightCoral;
            btnCancel.FlatAppearance.BorderSize = 0;
            btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnCancel.Location = new System.Drawing.Point(249, 355);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new System.Drawing.Size(129, 63);
            btnCancel.TabIndex = 40;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblTitle.Location = new System.Drawing.Point(316, 32);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new System.Drawing.Size(150, 32);
            lblTitle.TabIndex = 39;
            lblTitle.Text = "Vote Survey";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new System.Drawing.Point(103, 92);
            lblName.Name = "lblName";
            lblName.Size = new System.Drawing.Size(59, 25);
            lblName.TabIndex = 37;
            lblName.Text = "Name";
            // 
            // txtName
            // 
            txtName.AutoSize = true;
            txtName.Location = new System.Drawing.Point(203, 92);
            txtName.Name = "txtName";
            txtName.Size = new System.Drawing.Size(59, 25);
            txtName.TabIndex = 50;
            txtName.Text = "Name";
            // 
            // txtQuestion
            // 
            txtQuestion.AutoSize = true;
            txtQuestion.Location = new System.Drawing.Point(203, 125);
            txtQuestion.Name = "txtQuestion";
            txtQuestion.Size = new System.Drawing.Size(84, 25);
            txtQuestion.TabIndex = 51;
            txtQuestion.Text = "Question";
            // 
            // comboOptions
            // 
            comboOptions.FormattingEnabled = true;
            comboOptions.Location = new System.Drawing.Point(390, 125);
            comboOptions.Name = "comboOptions";
            comboOptions.Size = new System.Drawing.Size(182, 33);
            comboOptions.TabIndex = 52;
            // 
            // VoteSurvey
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(800, 450);
            Controls.Add(comboOptions);
            Controls.Add(txtQuestion);
            Controls.Add(txtName);
            Controls.Add(lblOptions);
            Controls.Add(lblQuestion);
            Controls.Add(btnConfirm);
            Controls.Add(btnCancel);
            Controls.Add(lblTitle);
            Controls.Add(lblName);
            Name = "VoteSurvey";
            Text = "VoteSurvey";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.Label lblOptions;
        private System.Windows.Forms.Label lblQuestion;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label txtName;
        private System.Windows.Forms.Label txtQuestion;
        private System.Windows.Forms.ComboBox comboOptions;
    }
}