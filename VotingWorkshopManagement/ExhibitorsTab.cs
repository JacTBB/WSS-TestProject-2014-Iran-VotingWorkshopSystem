using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VotingWorkshopManagement.Models;
using VotingWorkshopManagement.Popups;
using static VotingWorkshopManagement.WorkshopsTab;

namespace VotingWorkshopManagement
{
    public partial class ExhibitorsTab : Form
    {
        public static VotingWorkshopSystemContext dbContext;
        public BindingList<UsersData> usersList = new BindingList<UsersData>();
        public BindingSource usersBindingSource;

        public ExhibitorsTab(VotingWorkshopSystemContext dbContext)
        {
            InitializeComponent();
            ExhibitorsTab.dbContext = dbContext;
            usersBindingSource = new BindingSource { DataSource = usersList };

            RefreshUsersTableData();

            #region Configure UsersTable
            usersTable.DataSource = usersBindingSource;
            usersTable.AllowUserToAddRows = false;
            usersTable.MultiSelect = false;
            usersTable.RowHeadersVisible = false;
            usersTable.Columns["UserTypeId"].Visible = false;
            #endregion
        }

        public class UsersData
        {
            public int UserId { get; set; }
            public int UserTypeId { get; set; }

            public string UserType { get; set; }
            public string Username { get; set; }
            public string FullName { get; set; }
            public string Tel { get; set; }
        }

        public void RefreshUsersTableData()
        {
            usersList.Clear();

            var allUsers = dbContext.Users
                .Include(t => t.UserType)
                .OrderByDescending(u => u.UserTypeId)
                .ToList();

            foreach (var user in allUsers)
            {
                usersList.Add(new UsersData
                {
                    UserId = user.UserId,
                    UserTypeId = user.UserTypeId,

                    UserType = user.UserType.UserTypeName,
                    Username = user.Username,
                    FullName = user.FullName,
                    Tel = user.Tel,
                });
            }

            usersTable.Refresh();
        }

        private void btnAddExhibitor_Click(object sender, EventArgs e)
        {
            Form popup = new AddExhibitor(dbContext, this)
            {
                TopLevel = true,
                AutoScroll = false,
                FormBorderStyle = FormBorderStyle.FixedSingle,
            };
            popup.ShowDialog(this);
        }
    }
}
