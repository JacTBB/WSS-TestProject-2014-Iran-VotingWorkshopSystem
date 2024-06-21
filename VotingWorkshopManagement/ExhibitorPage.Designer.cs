namespace VotingWorkshopManagement
{
    partial class ExhibitorPage
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
            lblUser = new System.Windows.Forms.Label();
            lblTitle = new System.Windows.Forms.Label();
            btnRequest = new System.Windows.Forms.Button();
            btnVote = new System.Windows.Forms.Button();
            btnHome = new System.Windows.Forms.Button();
            panelMain = new System.Windows.Forms.Panel();
            btnLogout = new System.Windows.Forms.Button();
            panelNav.SuspendLayout();
            SuspendLayout();
            // 
            // panelNav
            // 
            panelNav.AutoSize = true;
            panelNav.BackColor = System.Drawing.Color.IndianRed;
            panelNav.Controls.Add(btnLogout);
            panelNav.Controls.Add(lblUser);
            panelNav.Controls.Add(lblTitle);
            panelNav.Controls.Add(btnRequest);
            panelNav.Controls.Add(btnVote);
            panelNav.Controls.Add(btnHome);
            panelNav.Dock = System.Windows.Forms.DockStyle.Top;
            panelNav.Location = new System.Drawing.Point(0, 0);
            panelNav.Name = "panelNav";
            panelNav.Padding = new System.Windows.Forms.Padding(5);
            panelNav.Size = new System.Drawing.Size(1258, 68);
            panelNav.TabIndex = 3;
            // 
            // lblUser
            // 
            lblUser.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            lblUser.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblUser.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            lblUser.Location = new System.Drawing.Point(1000, 19);
            lblUser.Name = "lblUser";
            lblUser.Size = new System.Drawing.Size(158, 36);
            lblUser.TabIndex = 6;
            lblUser.Text = "Admin";
            lblUser.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblTitle.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            lblTitle.Location = new System.Drawing.Point(23, 18);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new System.Drawing.Size(375, 36);
            lblTitle.TabIndex = 5;
            lblTitle.Text = "WSS Exhbitions Management";
            // 
            // btnRequest
            // 
            btnRequest.BackColor = System.Drawing.Color.IndianRed;
            btnRequest.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            btnRequest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnRequest.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnRequest.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            btnRequest.Location = new System.Drawing.Point(678, 13);
            btnRequest.Name = "btnRequest";
            btnRequest.Size = new System.Drawing.Size(120, 47);
            btnRequest.TabIndex = 2;
            btnRequest.Text = "Request";
            btnRequest.UseVisualStyleBackColor = false;
            btnRequest.Click += btnRequest_Click;
            // 
            // btnVote
            // 
            btnVote.BackColor = System.Drawing.Color.IndianRed;
            btnVote.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            btnVote.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnVote.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnVote.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            btnVote.Location = new System.Drawing.Point(552, 13);
            btnVote.Name = "btnVote";
            btnVote.Size = new System.Drawing.Size(120, 47);
            btnVote.TabIndex = 1;
            btnVote.Text = "Vote";
            btnVote.UseVisualStyleBackColor = false;
            btnVote.Click += btnVote_Click;
            // 
            // btnHome
            // 
            btnHome.BackColor = System.Drawing.Color.IndianRed;
            btnHome.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnHome.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnHome.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            btnHome.Location = new System.Drawing.Point(426, 13);
            btnHome.Name = "btnHome";
            btnHome.Size = new System.Drawing.Size(120, 47);
            btnHome.TabIndex = 0;
            btnHome.Text = "Home";
            btnHome.UseVisualStyleBackColor = false;
            btnHome.Click += btnHome_Click;
            // 
            // panelMain
            // 
            panelMain.AutoSize = true;
            panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            panelMain.Location = new System.Drawing.Point(0, 68);
            panelMain.Name = "panelMain";
            panelMain.Size = new System.Drawing.Size(1258, 676);
            panelMain.TabIndex = 4;
            // 
            // btnLogout
            // 
            btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnLogout.ForeColor = System.Drawing.Color.Snow;
            btnLogout.Location = new System.Drawing.Point(1170, 19);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new System.Drawing.Size(86, 36);
            btnLogout.TabIndex = 7;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += btnLogout_Click;
            // 
            // ExhibitorPage
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1258, 744);
            Controls.Add(panelMain);
            Controls.Add(panelNav);
            Name = "ExhibitorPage";
            Text = "ExhibitorPage";
            panelNav.ResumeLayout(false);
            panelNav.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Panel panelNav;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnRequest;
        private System.Windows.Forms.Button btnVote;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Button btnLogout;
    }
}