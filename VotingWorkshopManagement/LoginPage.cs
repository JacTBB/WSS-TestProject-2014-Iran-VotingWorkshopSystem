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

namespace VotingWorkshopManagement
{
    public partial class LoginPage : Form
    {
        public VotingWorkshopSystemContext dbContext = new VotingWorkshopSystemContext();
        public LoginPage()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            var Username = txtUsername.Text;
            var Password = txtPassword.Text;

            var user = dbContext.Users.FirstOrDefault(u => u.Username.Equals(Username));
            if (user == null)
            {
                MessageBox.Show("Invalid Username!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var hmac = new HMACSHA512(user.PasswordSalt);
            var computedHash = hmac.ComputeHash(Encoding.UTF8.GetBytes(Password));
            for (int i = 0; i < computedHash.Length; i++)
            {
                if (computedHash[i] != user.PasswordHash[i]) {
                    MessageBox.Show("Invalid Password!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }

            CurrentUser.user = user;
            if (user.UserTypeId == 2)
            {
                AdminPage.dbContext = dbContext;
                AdminPage adminPage = new AdminPage(user);
                adminPage.Show();
                adminPage.FormClosed += PageClosedHandler;
            }
            if (user.UserTypeId == 1)
            {
                ExhibitorPage.dbContext = dbContext;
                ExhibitorPage exhibitorPage = new ExhibitorPage(user);
                exhibitorPage.Show();
                exhibitorPage.FormClosed += PageClosedHandler;
            }
            this.Hide();
        }

        private void PageClosedHandler(object sender, EventArgs e)
        {
            this.Show();
            CurrentUser.user = null;
            txtUsername.Text = string.Empty;
            txtPassword.Text = string.Empty;
        }
    }

    public class CurrentUser
    {
        public static User user { get; set; }
    }
}
