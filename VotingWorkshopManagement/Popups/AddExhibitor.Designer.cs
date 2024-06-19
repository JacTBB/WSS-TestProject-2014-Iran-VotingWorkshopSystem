namespace VotingWorkshopManagement.Popups
{
    partial class AddExhibitor
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
            lblUsername = new System.Windows.Forms.Label();
            txtUsername = new System.Windows.Forms.TextBox();
            txtPassword = new System.Windows.Forms.TextBox();
            lblPassword = new System.Windows.Forms.Label();
            txtFullName = new System.Windows.Forms.TextBox();
            lblFullName = new System.Windows.Forms.Label();
            txtTel = new System.Windows.Forms.TextBox();
            lblTel = new System.Windows.Forms.Label();
            lblTitle = new System.Windows.Forms.Label();
            btnCancel = new System.Windows.Forms.Button();
            btnConfirm = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Location = new System.Drawing.Point(189, 135);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new System.Drawing.Size(91, 25);
            lblUsername.TabIndex = 0;
            lblUsername.Text = "Username";
            // 
            // txtUsername
            // 
            txtUsername.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            txtUsername.Location = new System.Drawing.Point(189, 163);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new System.Drawing.Size(168, 31);
            txtUsername.TabIndex = 1;
            // 
            // txtPassword
            // 
            txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            txtPassword.Location = new System.Drawing.Point(444, 163);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new System.Drawing.Size(168, 31);
            txtPassword.TabIndex = 3;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Location = new System.Drawing.Point(444, 135);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new System.Drawing.Size(87, 25);
            lblPassword.TabIndex = 2;
            lblPassword.Text = "Password";
            // 
            // txtFullName
            // 
            txtFullName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            txtFullName.Location = new System.Drawing.Point(189, 247);
            txtFullName.Name = "txtFullName";
            txtFullName.Size = new System.Drawing.Size(168, 31);
            txtFullName.TabIndex = 5;
            // 
            // lblFullName
            // 
            lblFullName.AutoSize = true;
            lblFullName.Location = new System.Drawing.Point(189, 219);
            lblFullName.Name = "lblFullName";
            lblFullName.Size = new System.Drawing.Size(91, 25);
            lblFullName.TabIndex = 4;
            lblFullName.Text = "Full Name";
            // 
            // txtTel
            // 
            txtTel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            txtTel.Location = new System.Drawing.Point(444, 247);
            txtTel.Name = "txtTel";
            txtTel.Size = new System.Drawing.Size(168, 31);
            txtTel.TabIndex = 7;
            // 
            // lblTel
            // 
            lblTel.AutoSize = true;
            lblTel.Location = new System.Drawing.Point(444, 219);
            lblTel.Name = "lblTel";
            lblTel.Size = new System.Drawing.Size(92, 25);
            lblTel.TabIndex = 6;
            lblTel.Text = "Telephone";
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblTitle.Location = new System.Drawing.Point(318, 46);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new System.Drawing.Size(171, 32);
            lblTitle.TabIndex = 8;
            lblTitle.Text = "Add Exhibitor";
            // 
            // btnCancel
            // 
            btnCancel.BackColor = System.Drawing.Color.LightCoral;
            btnCancel.FlatAppearance.BorderSize = 0;
            btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnCancel.Location = new System.Drawing.Point(252, 343);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new System.Drawing.Size(129, 63);
            btnCancel.TabIndex = 9;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnConfirm
            // 
            btnConfirm.BackColor = System.Drawing.Color.DarkSeaGreen;
            btnConfirm.FlatAppearance.BorderSize = 0;
            btnConfirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnConfirm.Location = new System.Drawing.Point(424, 343);
            btnConfirm.Name = "btnConfirm";
            btnConfirm.Size = new System.Drawing.Size(129, 63);
            btnConfirm.TabIndex = 10;
            btnConfirm.Text = "Confirm";
            btnConfirm.UseVisualStyleBackColor = false;
            btnConfirm.Click += btnConfirm_Click;
            // 
            // AddExhibitor
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(800, 450);
            Controls.Add(btnConfirm);
            Controls.Add(btnCancel);
            Controls.Add(lblTitle);
            Controls.Add(txtTel);
            Controls.Add(lblTel);
            Controls.Add(txtFullName);
            Controls.Add(lblFullName);
            Controls.Add(txtPassword);
            Controls.Add(lblPassword);
            Controls.Add(txtUsername);
            Controls.Add(lblUsername);
            Name = "AddExhibitor";
            Text = "AddExhibitor";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtFullName;
        private System.Windows.Forms.Label lblFullName;
        private System.Windows.Forms.TextBox txtTel;
        private System.Windows.Forms.Label lblTel;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnConfirm;
    }
}