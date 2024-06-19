namespace VotingWorkshopManagement.Popups
{
    partial class AddSaloon
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
            btnConfirm = new System.Windows.Forms.Button();
            btnCancel = new System.Windows.Forms.Button();
            lblTitle = new System.Windows.Forms.Label();
            txtName = new System.Windows.Forms.TextBox();
            lblName = new System.Windows.Forms.Label();
            SuspendLayout();
            // 
            // btnConfirm
            // 
            btnConfirm.BackColor = System.Drawing.Color.DarkSeaGreen;
            btnConfirm.FlatAppearance.BorderSize = 0;
            btnConfirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnConfirm.Location = new System.Drawing.Point(424, 342);
            btnConfirm.Name = "btnConfirm";
            btnConfirm.Size = new System.Drawing.Size(129, 63);
            btnConfirm.TabIndex = 21;
            btnConfirm.Text = "Confirm";
            btnConfirm.UseVisualStyleBackColor = false;
            btnConfirm.Click += btnConfirm_Click;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = System.Drawing.Color.LightCoral;
            btnCancel.FlatAppearance.BorderSize = 0;
            btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnCancel.Location = new System.Drawing.Point(252, 342);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new System.Drawing.Size(129, 63);
            btnCancel.TabIndex = 20;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblTitle.Location = new System.Drawing.Point(318, 45);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new System.Drawing.Size(146, 32);
            lblTitle.TabIndex = 19;
            lblTitle.Text = "Add Saloon";
            // 
            // txtName
            // 
            txtName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            txtName.Location = new System.Drawing.Point(306, 195);
            txtName.Name = "txtName";
            txtName.Size = new System.Drawing.Size(168, 31);
            txtName.TabIndex = 12;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new System.Drawing.Point(306, 167);
            lblName.Name = "lblName";
            lblName.Size = new System.Drawing.Size(59, 25);
            lblName.TabIndex = 11;
            lblName.Text = "Name";
            // 
            // AddSaloon
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(800, 450);
            Controls.Add(btnConfirm);
            Controls.Add(btnCancel);
            Controls.Add(lblTitle);
            Controls.Add(txtName);
            Controls.Add(lblName);
            Name = "AddSaloon";
            Text = "AddSaloon";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblName;
    }
}