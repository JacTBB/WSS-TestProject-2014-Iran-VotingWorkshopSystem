namespace VotingWorkshopManagement
{
    partial class AdminPage
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
            panelNav = new System.Windows.Forms.Panel();
            lblTitle = new System.Windows.Forms.Label();
            btnWorkshops = new System.Windows.Forms.Button();
            btnExhibitors = new System.Windows.Forms.Button();
            btnResults = new System.Windows.Forms.Button();
            btnSaloons = new System.Windows.Forms.Button();
            btnVoting = new System.Windows.Forms.Button();
            panelMain = new System.Windows.Forms.Panel();
            panelNav.SuspendLayout();
            SuspendLayout();
            // 
            // panelNav
            // 
            panelNav.BackColor = System.Drawing.Color.IndianRed;
            panelNav.Controls.Add(lblTitle);
            panelNav.Controls.Add(btnWorkshops);
            panelNav.Controls.Add(btnExhibitors);
            panelNav.Controls.Add(btnResults);
            panelNav.Controls.Add(btnSaloons);
            panelNav.Controls.Add(btnVoting);
            panelNav.Dock = System.Windows.Forms.DockStyle.Top;
            panelNav.Location = new System.Drawing.Point(0, 0);
            panelNav.Name = "panelNav";
            panelNav.Size = new System.Drawing.Size(1258, 88);
            panelNav.TabIndex = 1;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblTitle.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            lblTitle.Location = new System.Drawing.Point(12, 27);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new System.Drawing.Size(375, 36);
            lblTitle.TabIndex = 5;
            lblTitle.Text = "WSS Exhbitions Management";
            // 
            // btnWorkshops
            // 
            btnWorkshops.BackColor = System.Drawing.Color.IndianRed;
            btnWorkshops.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlText;
            btnWorkshops.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnWorkshops.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnWorkshops.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            btnWorkshops.Location = new System.Drawing.Point(1068, 24);
            btnWorkshops.Name = "btnWorkshops";
            btnWorkshops.Size = new System.Drawing.Size(156, 47);
            btnWorkshops.TabIndex = 4;
            btnWorkshops.Text = "Workshops";
            btnWorkshops.UseVisualStyleBackColor = false;
            btnWorkshops.Click += btnWorkshops_Click;
            // 
            // btnExhibitors
            // 
            btnExhibitors.BackColor = System.Drawing.Color.IndianRed;
            btnExhibitors.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlText;
            btnExhibitors.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnExhibitors.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnExhibitors.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            btnExhibitors.Location = new System.Drawing.Point(923, 24);
            btnExhibitors.Name = "btnExhibitors";
            btnExhibitors.Size = new System.Drawing.Size(139, 47);
            btnExhibitors.TabIndex = 3;
            btnExhibitors.Text = "Exhibitors";
            btnExhibitors.UseVisualStyleBackColor = false;
            btnExhibitors.Click += btnExhibitors_Click;
            // 
            // btnResults
            // 
            btnResults.BackColor = System.Drawing.Color.IndianRed;
            btnResults.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlText;
            btnResults.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnResults.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnResults.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            btnResults.Location = new System.Drawing.Point(778, 24);
            btnResults.Name = "btnResults";
            btnResults.Size = new System.Drawing.Size(139, 47);
            btnResults.TabIndex = 2;
            btnResults.Text = "Results";
            btnResults.UseVisualStyleBackColor = false;
            btnResults.Click += btnResults_Click;
            // 
            // btnSaloons
            // 
            btnSaloons.BackColor = System.Drawing.Color.IndianRed;
            btnSaloons.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlText;
            btnSaloons.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnSaloons.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnSaloons.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            btnSaloons.Location = new System.Drawing.Point(633, 24);
            btnSaloons.Name = "btnSaloons";
            btnSaloons.Size = new System.Drawing.Size(139, 47);
            btnSaloons.TabIndex = 1;
            btnSaloons.Text = "Saloons";
            btnSaloons.UseVisualStyleBackColor = false;
            btnSaloons.Click += btnSaloons_Click;
            // 
            // btnVoting
            // 
            btnVoting.BackColor = System.Drawing.Color.IndianRed;
            btnVoting.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlText;
            btnVoting.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnVoting.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnVoting.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            btnVoting.Location = new System.Drawing.Point(488, 24);
            btnVoting.Name = "btnVoting";
            btnVoting.Size = new System.Drawing.Size(139, 47);
            btnVoting.TabIndex = 0;
            btnVoting.Text = "Voting";
            btnVoting.UseVisualStyleBackColor = false;
            btnVoting.Click += btnVoting_Click;
            // 
            // panelMain
            // 
            panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            panelMain.Location = new System.Drawing.Point(0, 88);
            panelMain.Name = "panelMain";
            panelMain.Size = new System.Drawing.Size(1258, 656);
            panelMain.TabIndex = 2;
            // 
            // AdminPage
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1258, 744);
            Controls.Add(panelMain);
            Controls.Add(panelNav);
            Name = "AdminPage";
            Text = "HomePage";
            panelNav.ResumeLayout(false);
            panelNav.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private System.Windows.Forms.Panel panelNav;
        private System.Windows.Forms.Button btnSaloons;
        private System.Windows.Forms.Button btnVoting;
        private System.Windows.Forms.Button btnResults;
        private System.Windows.Forms.Button btnWorkshops;
        private System.Windows.Forms.Button btnExhibitors;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel panelMain;
    }
}