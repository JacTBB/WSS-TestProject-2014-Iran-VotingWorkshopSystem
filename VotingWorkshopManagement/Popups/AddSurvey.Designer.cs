namespace VotingWorkshopManagement.Popups
{
    partial class AddSurvey
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
            btnConfirm = new System.Windows.Forms.Button();
            btnCancel = new System.Windows.Forms.Button();
            lblTitle = new System.Windows.Forms.Label();
            txtName = new System.Windows.Forms.TextBox();
            lblName = new System.Windows.Forms.Label();
            txtQuestion = new System.Windows.Forms.TextBox();
            lblQuestion = new System.Windows.Forms.Label();
            dateStart = new System.Windows.Forms.DateTimePicker();
            lblStartDate = new System.Windows.Forms.Label();
            lblEndDate = new System.Windows.Forms.Label();
            dateEnd = new System.Windows.Forms.DateTimePicker();
            lblOptions = new System.Windows.Forms.Label();
            optionsTable = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)optionsTable).BeginInit();
            SuspendLayout();
            // 
            // btnConfirm
            // 
            btnConfirm.BackColor = System.Drawing.Color.DarkSeaGreen;
            btnConfirm.FlatAppearance.BorderSize = 0;
            btnConfirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnConfirm.Location = new System.Drawing.Point(421, 357);
            btnConfirm.Name = "btnConfirm";
            btnConfirm.Size = new System.Drawing.Size(129, 63);
            btnConfirm.TabIndex = 26;
            btnConfirm.Text = "Confirm";
            btnConfirm.UseVisualStyleBackColor = false;
            btnConfirm.Click += btnConfirm_Click;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = System.Drawing.Color.LightCoral;
            btnCancel.FlatAppearance.BorderSize = 0;
            btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnCancel.Location = new System.Drawing.Point(249, 357);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new System.Drawing.Size(129, 63);
            btnCancel.TabIndex = 25;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblTitle.Location = new System.Drawing.Point(316, 34);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new System.Drawing.Size(146, 32);
            lblTitle.TabIndex = 24;
            lblTitle.Text = "Add Survey";
            // 
            // txtName
            // 
            txtName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            txtName.Location = new System.Drawing.Point(31, 122);
            txtName.Name = "txtName";
            txtName.Size = new System.Drawing.Size(168, 31);
            txtName.TabIndex = 23;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new System.Drawing.Point(31, 94);
            lblName.Name = "lblName";
            lblName.Size = new System.Drawing.Size(59, 25);
            lblName.TabIndex = 22;
            lblName.Text = "Name";
            // 
            // txtQuestion
            // 
            txtQuestion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            txtQuestion.Location = new System.Drawing.Point(259, 122);
            txtQuestion.Name = "txtQuestion";
            txtQuestion.Size = new System.Drawing.Size(168, 31);
            txtQuestion.TabIndex = 28;
            // 
            // lblQuestion
            // 
            lblQuestion.AutoSize = true;
            lblQuestion.Location = new System.Drawing.Point(259, 94);
            lblQuestion.Name = "lblQuestion";
            lblQuestion.Size = new System.Drawing.Size(84, 25);
            lblQuestion.TabIndex = 27;
            lblQuestion.Text = "Question";
            // 
            // dateStart
            // 
            dateStart.Location = new System.Drawing.Point(31, 199);
            dateStart.Name = "dateStart";
            dateStart.Size = new System.Drawing.Size(300, 31);
            dateStart.TabIndex = 31;
            // 
            // lblStartDate
            // 
            lblStartDate.AutoSize = true;
            lblStartDate.Location = new System.Drawing.Point(31, 171);
            lblStartDate.Name = "lblStartDate";
            lblStartDate.Size = new System.Drawing.Size(90, 25);
            lblStartDate.TabIndex = 32;
            lblStartDate.Text = "Start Date";
            // 
            // lblEndDate
            // 
            lblEndDate.AutoSize = true;
            lblEndDate.Location = new System.Drawing.Point(31, 248);
            lblEndDate.Name = "lblEndDate";
            lblEndDate.Size = new System.Drawing.Size(84, 25);
            lblEndDate.TabIndex = 33;
            lblEndDate.Text = "End Date";
            // 
            // dateEnd
            // 
            dateEnd.Location = new System.Drawing.Point(31, 276);
            dateEnd.Name = "dateEnd";
            dateEnd.Size = new System.Drawing.Size(300, 31);
            dateEnd.TabIndex = 34;
            // 
            // lblOptions
            // 
            lblOptions.AutoSize = true;
            lblOptions.Location = new System.Drawing.Point(461, 94);
            lblOptions.Name = "lblOptions";
            lblOptions.Size = new System.Drawing.Size(76, 25);
            lblOptions.TabIndex = 35;
            lblOptions.Text = "Options";
            // 
            // optionsTable
            // 
            optionsTable.AllowUserToOrderColumns = true;
            optionsTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            optionsTable.Location = new System.Drawing.Point(461, 127);
            optionsTable.Name = "optionsTable";
            optionsTable.RowHeadersWidth = 62;
            optionsTable.RowTemplate.Height = 33;
            optionsTable.Size = new System.Drawing.Size(308, 201);
            optionsTable.TabIndex = 36;
            // 
            // AddSurvey
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(800, 450);
            Controls.Add(optionsTable);
            Controls.Add(lblOptions);
            Controls.Add(dateEnd);
            Controls.Add(lblEndDate);
            Controls.Add(lblStartDate);
            Controls.Add(dateStart);
            Controls.Add(txtQuestion);
            Controls.Add(lblQuestion);
            Controls.Add(btnConfirm);
            Controls.Add(btnCancel);
            Controls.Add(lblTitle);
            Controls.Add(txtName);
            Controls.Add(lblName);
            Name = "AddSurvey";
            Text = "AddSurvey";
            ((System.ComponentModel.ISupportInitialize)optionsTable).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtQuestion;
        private System.Windows.Forms.Label lblQuestion;
        private System.Windows.Forms.DateTimePicker dateStart;
        private System.Windows.Forms.Label lblStartDate;
        private System.Windows.Forms.Label lblEndDate;
        private System.Windows.Forms.DateTimePicker dateEnd;
        private System.Windows.Forms.Label lblOptions;
        private System.Windows.Forms.DataGridView optionsTable;
    }
}