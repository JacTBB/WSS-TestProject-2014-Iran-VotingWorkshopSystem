namespace VotingWorkshopManagement
{
    partial class WorkshopsTab
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
            lblTitle = new System.Windows.Forms.Label();
            workshopsTable = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)workshopsTable).BeginInit();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Location = new System.Drawing.Point(575, 33);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new System.Drawing.Size(102, 25);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Workshops";
            // 
            // workshopsTable
            // 
            workshopsTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            workshopsTable.Location = new System.Drawing.Point(29, 76);
            workshopsTable.Name = "workshopsTable";
            workshopsTable.RowHeadersWidth = 62;
            workshopsTable.RowTemplate.Height = 33;
            workshopsTable.Size = new System.Drawing.Size(1199, 541);
            workshopsTable.TabIndex = 1;
            workshopsTable.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.workshopsTable_CellContentClick);
            // 
            // WorkshopsTab
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1258, 644);
            Controls.Add(workshopsTable);
            Controls.Add(lblTitle);
            Name = "WorkshopsTab";
            Text = "WorkshopsTab";
            ((System.ComponentModel.ISupportInitialize)workshopsTable).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.DataGridView workshopsTable;
    }
}