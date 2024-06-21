namespace VotingWorkshopManagement
{
    partial class SurveyTab
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
            surveysTable = new System.Windows.Forms.DataGridView();
            lblTitle = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)surveysTable).BeginInit();
            SuspendLayout();
            // 
            // surveysTable
            // 
            surveysTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            surveysTable.Location = new System.Drawing.Point(43, 99);
            surveysTable.Name = "surveysTable";
            surveysTable.RowHeadersWidth = 62;
            surveysTable.RowTemplate.Height = 33;
            surveysTable.Size = new System.Drawing.Size(1167, 506);
            surveysTable.TabIndex = 4;
            surveysTable.CellContentClick += surveysTable_CellContentClick;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblTitle.Location = new System.Drawing.Point(575, 36);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new System.Drawing.Size(103, 32);
            lblTitle.TabIndex = 3;
            lblTitle.Text = "Surveys";
            // 
            // SurveyTab
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1258, 644);
            Controls.Add(surveysTable);
            Controls.Add(lblTitle);
            Name = "SurveyTab";
            Text = "SurveyTab";
            ((System.ComponentModel.ISupportInitialize)surveysTable).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.DataGridView surveysTable;
        private System.Windows.Forms.Label lblTitle;
    }
}