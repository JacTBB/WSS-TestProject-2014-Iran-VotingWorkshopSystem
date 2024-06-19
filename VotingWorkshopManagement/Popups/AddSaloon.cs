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
    public partial class AddSaloon : Form
    {
        public static VotingWorkshopSystemContext dbContext;
        public SaloonsTab saloonsTab;

        public AddSaloon(VotingWorkshopSystemContext dbContext, SaloonsTab saloonsTab)
        {
            InitializeComponent();
            AddSaloon.dbContext = dbContext;
            this.saloonsTab = saloonsTab;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            var Name = txtName.Text;

            if (Name.IsNullOrEmpty())
            {
                MessageBox.Show("Missing Inputs!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var saloon = new Saloon
            {
                SaloonName = Name,
            };
            dbContext.Add(saloon);
            dbContext.SaveChanges();

            saloonsTab.RefreshSaloonsTableData();

            MessageBox.Show("Saloon Added", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.Close();
        }
    }
}
