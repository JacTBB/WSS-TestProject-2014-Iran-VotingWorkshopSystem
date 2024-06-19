using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static VotingWorkshopManagement.ExhibitorsTab;
using VotingWorkshopManagement.Models;
using Microsoft.EntityFrameworkCore;
using VotingWorkshopManagement.Popups;

namespace VotingWorkshopManagement
{
    public partial class SaloonsTab : Form
    {
        public static VotingWorkshopSystemContext dbContext;
        public BindingList<Saloon> saloonsList = new BindingList<Saloon>();
        public BindingSource saloonsBindingSource;

        public SaloonsTab(VotingWorkshopSystemContext dbContext)
        {
            InitializeComponent();
            SaloonsTab.dbContext = dbContext;
            saloonsBindingSource = new BindingSource { DataSource = saloonsList };

            RefreshSaloonsTableData();

            #region Configure UsersTable
            saloonsTable.DataSource = saloonsBindingSource;
            saloonsTable.AllowUserToAddRows = false;
            saloonsTable.MultiSelect = false;
            saloonsTable.RowHeadersVisible = false;
            saloonsTable.Columns["WorkshopRequests"].Visible = false;
            #endregion
        }

        public void RefreshSaloonsTableData()
        {
            saloonsList.Clear();

            var allSaloons = dbContext.Saloons.ToList();

            foreach (var saloon in allSaloons)
            {
                saloonsList.Add(saloon);
            }

            saloonsTable.Refresh();
        }

        private void btnAddSaloon_Click(object sender, EventArgs e)
        {
            Form popup = new AddSaloon(dbContext, this)
            {
                TopLevel = true,
                AutoScroll = false,
                FormBorderStyle = FormBorderStyle.FixedSingle,
            };
            popup.ShowDialog(this);
        }
    }
}
