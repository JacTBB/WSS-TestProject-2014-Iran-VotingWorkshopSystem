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

            //TODO: Password Hashing
            var user = new User
            {
                UserTypeId = 1,
                Username = Username,
                Password = Password,
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
