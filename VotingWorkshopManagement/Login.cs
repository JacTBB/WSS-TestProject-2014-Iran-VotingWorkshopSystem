using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VotingWorkshopManagement.Models;

namespace VotingWorkshopManagement
{
    public partial class Login : Form
    {
        public VotingWorkshopSystemContext dbContext = new VotingWorkshopSystemContext();
        public Login()
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
            if (user.Password != Password)
            {
                MessageBox.Show("Invalid Password!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
