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
    public partial class ExhibitorPage : Form
    {
        public static VotingWorkshopSystemContext dbContext;
        public static User user;

        Form homeTab = new HomeTab(dbContext)
        {
            TopLevel = false,
            AutoScroll = true,
            FormBorderStyle = FormBorderStyle.None,
            Dock = DockStyle.Fill,
        };

        public ExhibitorPage(User user)
        {
            InitializeComponent();
            ExhibitorPage.user = user;

            panelMain.Controls.Add(homeTab);

            homeTab.Show();

            lblUser.Text = "Hi, " + user.Username;
        }

        private void HideAllTabs()
        {
            homeTab.Hide();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            HideAllTabs();
            homeTab.Show();
        }

        private void btnVote_Click(object sender, EventArgs e)
        {
            HideAllTabs();
        }

        private void btnRequest_Click(object sender, EventArgs e)
        {
            HideAllTabs();
        }
    }
}
