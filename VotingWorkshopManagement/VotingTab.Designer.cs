namespace VotingWorkshopManagement
{
    partial class VotingTab
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
            btnAddSurvey = new System.Windows.Forms.Button();
            surveysTable = new System.Windows.Forms.DataGridView();
            lblTitle = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)surveysTable).BeginInit();
            SuspendLayout();
            // 
            // btnAddSurvey
            // 
            btnAddSurvey.BackColor = System.Drawing.Color.SandyBrown;
            btnAddSurvey.FlatAppearance.BorderSize = 0;
            btnAddSurvey.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnAddSurvey.Location = new System.Drawing.Point(1083, 24);
            btnAddSurvey.Name = "btnAddSurvey";
            btnAddSurvey.Size = new System.Drawing.Size(146, 47);
            btnAddSurvey.TabIndex = 9;
            btnAddSurvey.Text = "Add Survey";
            btnAddSurvey.UseVisualStyleBackColor = false;
            btnAddSurvey.Click += btnAddSurvey_Click;
            // 
            // surveysTable
            // 
            surveysTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            surveysTable.Location = new System.Drawing.Point(30, 80);
            surveysTable.Name = "surveysTable";
            surveysTable.RowHeadersWidth = 62;
            surveysTable.RowTemplate.Height = 33;
            surveysTable.Size = new System.Drawing.Size(1199, 541);
            surveysTable.TabIndex = 8;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Location = new System.Drawing.Point(579, 35);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new System.Drawing.Size(130, 25);
            lblTitle.TabIndex = 7;
            lblTitle.Text = "Voting Surveys";
            // 
            // VotingTab
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1258, 644);
            Controls.Add(btnAddSurvey);
            Controls.Add(surveysTable);
            Controls.Add(lblTitle);
            Name = "VotingTab";
            Text = "VotingTab";
            ((System.ComponentModel.ISupportInitialize)surveysTable).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button btnAddSurvey;
        private System.Windows.Forms.DataGridView surveysTable;
        private System.Windows.Forms.Label lblTitle;
    }
}