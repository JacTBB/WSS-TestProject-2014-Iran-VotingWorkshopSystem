namespace VotingWorkshopManagement
{
    partial class HomeTab
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
            requestsTable = new System.Windows.Forms.DataGridView();
            lblRequests = new System.Windows.Forms.Label();
            NotificationsTable = new System.Windows.Forms.DataGridView();
            lblNotifications = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)requestsTable).BeginInit();
            ((System.ComponentModel.ISupportInitialize)NotificationsTable).BeginInit();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblTitle.Location = new System.Drawing.Point(590, 45);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new System.Drawing.Size(82, 32);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Home";
            // 
            // requestsTable
            // 
            requestsTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            requestsTable.Location = new System.Drawing.Point(658, 138);
            requestsTable.Name = "requestsTable";
            requestsTable.RowHeadersWidth = 62;
            requestsTable.RowTemplate.Height = 33;
            requestsTable.Size = new System.Drawing.Size(553, 473);
            requestsTable.TabIndex = 1;
            // 
            // lblRequests
            // 
            lblRequests.AutoSize = true;
            lblRequests.Location = new System.Drawing.Point(874, 98);
            lblRequests.Name = "lblRequests";
            lblRequests.Size = new System.Drawing.Size(113, 25);
            lblRequests.TabIndex = 2;
            lblRequests.Text = "My Requests";
            // 
            // NotificationsTable
            // 
            NotificationsTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            NotificationsTable.Location = new System.Drawing.Point(48, 138);
            NotificationsTable.Name = "NotificationsTable";
            NotificationsTable.RowHeadersWidth = 62;
            NotificationsTable.RowTemplate.Height = 33;
            NotificationsTable.Size = new System.Drawing.Size(553, 473);
            NotificationsTable.TabIndex = 3;
            // 
            // lblNotifications
            // 
            lblNotifications.AutoSize = true;
            lblNotifications.Location = new System.Drawing.Point(271, 98);
            lblNotifications.Name = "lblNotifications";
            lblNotifications.Size = new System.Drawing.Size(112, 25);
            lblNotifications.TabIndex = 4;
            lblNotifications.Text = "Notifications";
            // 
            // HomeTab
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.SystemColors.Control;
            ClientSize = new System.Drawing.Size(1258, 644);
            Controls.Add(lblNotifications);
            Controls.Add(NotificationsTable);
            Controls.Add(lblRequests);
            Controls.Add(requestsTable);
            Controls.Add(lblTitle);
            Name = "HomeTab";
            Text = "HomeTab";
            ((System.ComponentModel.ISupportInitialize)requestsTable).EndInit();
            ((System.ComponentModel.ISupportInitialize)NotificationsTable).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.DataGridView requestsTable;
        private System.Windows.Forms.Label lblRequests;
        private System.Windows.Forms.DataGridView NotificationsTable;
        private System.Windows.Forms.Label lblNotifications;
    }
}