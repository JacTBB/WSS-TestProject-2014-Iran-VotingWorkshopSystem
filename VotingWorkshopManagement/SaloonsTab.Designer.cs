namespace VotingWorkshopManagement
{
    partial class SaloonsTab
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
            btnAddSaloon = new System.Windows.Forms.Button();
            saloonsTable = new System.Windows.Forms.DataGridView();
            lblTitle = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)saloonsTable).BeginInit();
            SuspendLayout();
            // 
            // btnAddSaloon
            // 
            btnAddSaloon.BackColor = System.Drawing.Color.SandyBrown;
            btnAddSaloon.FlatAppearance.BorderSize = 0;
            btnAddSaloon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnAddSaloon.Location = new System.Drawing.Point(1083, 24);
            btnAddSaloon.Name = "btnAddSaloon";
            btnAddSaloon.Size = new System.Drawing.Size(146, 47);
            btnAddSaloon.TabIndex = 6;
            btnAddSaloon.Text = "Add Saloon";
            btnAddSaloon.UseVisualStyleBackColor = false;
            btnAddSaloon.Click += btnAddSaloon_Click;
            // 
            // saloonsTable
            // 
            saloonsTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            saloonsTable.Location = new System.Drawing.Point(30, 80);
            saloonsTable.Name = "saloonsTable";
            saloonsTable.RowHeadersWidth = 62;
            saloonsTable.RowTemplate.Height = 33;
            saloonsTable.Size = new System.Drawing.Size(1199, 541);
            saloonsTable.TabIndex = 5;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Location = new System.Drawing.Point(579, 35);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new System.Drawing.Size(75, 25);
            lblTitle.TabIndex = 4;
            lblTitle.Text = "Saloons";
            // 
            // SaloonsTab
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1258, 644);
            Controls.Add(btnAddSaloon);
            Controls.Add(saloonsTable);
            Controls.Add(lblTitle);
            Name = "SaloonsTab";
            Text = "SaloonsTab";
            ((System.ComponentModel.ISupportInitialize)saloonsTable).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button btnAddSaloon;
        private System.Windows.Forms.DataGridView saloonsTable;
        private System.Windows.Forms.Label lblTitle;
    }
}