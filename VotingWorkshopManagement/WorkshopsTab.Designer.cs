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
            panel1 = new System.Windows.Forms.Panel();
            panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)workshopsTable).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Location = new System.Drawing.Point(586, 54);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new System.Drawing.Size(102, 25);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Workshops";
            // 
            // workshopsTable
            // 
            workshopsTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            workshopsTable.Dock = System.Windows.Forms.DockStyle.Fill;
            workshopsTable.Location = new System.Drawing.Point(50, 50);
            workshopsTable.Name = "workshopsTable";
            workshopsTable.RowHeadersWidth = 62;
            workshopsTable.RowTemplate.Height = 33;
            workshopsTable.Size = new System.Drawing.Size(1158, 444);
            workshopsTable.TabIndex = 1;
            workshopsTable.CellContentClick += workshopsTable_CellContentClick;
            // 
            // panel1
            // 
            panel1.Controls.Add(lblTitle);
            panel1.Dock = System.Windows.Forms.DockStyle.Top;
            panel1.Location = new System.Drawing.Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(1258, 100);
            panel1.TabIndex = 2;
            // 
            // panel2
            // 
            panel2.BackColor = System.Drawing.SystemColors.Control;
            panel2.Controls.Add(workshopsTable);
            panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            panel2.Location = new System.Drawing.Point(0, 100);
            panel2.Name = "panel2";
            panel2.Padding = new System.Windows.Forms.Padding(50);
            panel2.Size = new System.Drawing.Size(1258, 544);
            panel2.TabIndex = 3;
            // 
            // WorkshopsTab
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new System.Drawing.Size(1258, 644);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "WorkshopsTab";
            Text = "WorkshopsTab";
            ((System.ComponentModel.ISupportInitialize)workshopsTable).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.DataGridView workshopsTable;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}