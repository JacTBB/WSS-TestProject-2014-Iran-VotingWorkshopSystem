namespace VotingWorkshopManagement
{
    partial class ExhibitorsTab
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
            usersTable = new System.Windows.Forms.DataGridView();
            btnAddExhibitor = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)usersTable).BeginInit();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Location = new System.Drawing.Point(578, 33);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new System.Drawing.Size(89, 25);
            lblTitle.TabIndex = 1;
            lblTitle.Text = "Exhibitors";
            // 
            // usersTable
            // 
            usersTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            usersTable.Location = new System.Drawing.Point(29, 78);
            usersTable.Name = "usersTable";
            usersTable.RowHeadersWidth = 62;
            usersTable.RowTemplate.Height = 33;
            usersTable.Size = new System.Drawing.Size(1199, 541);
            usersTable.TabIndex = 2;
            // 
            // btnAddExhibitor
            // 
            btnAddExhibitor.BackColor = System.Drawing.SystemColors.Info;
            btnAddExhibitor.Location = new System.Drawing.Point(1082, 22);
            btnAddExhibitor.Name = "btnAddExhibitor";
            btnAddExhibitor.Size = new System.Drawing.Size(146, 47);
            btnAddExhibitor.TabIndex = 3;
            btnAddExhibitor.Text = "Add Exhibitor";
            btnAddExhibitor.UseVisualStyleBackColor = false;
            btnAddExhibitor.Click += btnAddExhibitor_Click;
            // 
            // ExhibitorsTab
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1258, 644);
            Controls.Add(btnAddExhibitor);
            Controls.Add(usersTable);
            Controls.Add(lblTitle);
            Name = "ExhibitorsTab";
            Text = "ExhibitorsTab";
            ((System.ComponentModel.ISupportInitialize)usersTable).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.DataGridView usersTable;
        private System.Windows.Forms.Button btnAddExhibitor;
    }
}