using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VotingWorkshopManagement.Models;

namespace VotingWorkshopManagement.Popups
{
    public partial class AddExhibitor : Form
    {
        public static VotingWorkshopSystemContext dbContext;
        public ExhibitorsTab exhibitorsTab;

        public AddExhibitor(VotingWorkshopSystemContext dbContext, ExhibitorsTab exhibitorsTab)
        {
            InitializeComponent();
            AddExhibitor.dbContext = dbContext;
            this.exhibitorsTab = exhibitorsTab;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            var Username = txtUsername.Text;
            var Password = txtPassword.Text;
            var FullName = txtFullName.Text;
            var Tel = txtTel.Text;

            if (Username.IsNullOrEmpty() || Password.IsNullOrEmpty())
            {
                MessageBox.Show("Missing Inputs!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (FullName.IsNullOrEmpty() || Tel.IsNullOrEmpty())
            {
                MessageBox.Show("Missing Inputs!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var hmac = new HMACSHA512();
            var passwordSalt = hmac.Key;
            var passwordHash = hmac.ComputeHash(Encoding.UTF8.GetBytes(Password));

            var user = new User
            {
                UserTypeId = 1,
                Username = Username,
                PasswordHash = passwordHash,
                PasswordSalt = passwordSalt,
                FullName = FullName,
                Tel = Tel
            };
            dbContext.Add(user);
            dbContext.SaveChanges();

            exhibitorsTab.RefreshUsersTableData();

            MessageBox.Show("Exhibitor Added", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.Close();
        }
    }
}
