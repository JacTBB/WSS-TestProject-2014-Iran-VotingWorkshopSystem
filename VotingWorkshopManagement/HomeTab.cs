using Microsoft.EntityFrameworkCore;
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
using static VotingWorkshopManagement.ExhibitorsTab;

namespace VotingWorkshopManagement
{
    public partial class HomeTab : Form
    {
        public static VotingWorkshopSystemContext dbContext;
        public BindingList<WorkshopRequestData> requestsList = new BindingList<WorkshopRequestData>();

        public HomeTab(VotingWorkshopSystemContext dbContext)
        {
            InitializeComponent();
            HomeTab.dbContext = dbContext;

            RefreshWorkshopsTableData();

            #region Configure RequestsTable
            requestsTable.DataSource = requestsList;
            requestsTable.AllowUserToAddRows = false;
            requestsTable.MultiSelect = false;
            requestsTable.RowHeadersVisible = false;
            requestsTable.Columns["WorkshopRequestId"].Visible = false;
            requestsTable.Columns["UserId"].Visible = false;
            requestsTable.Columns["SaloonId"].Visible = false;
            requestsTable.Columns["CategoryId"].Visible = false;
            requestsTable.Columns["WorkshopTimeslotId"].Visible = false;
            requestsTable.Columns["StatusId"].Visible = false;
            requestsTable.Columns["User"].Visible = false;

            requestsTable.Columns["WorkshopTimeslot"].HeaderText = "Workshop Timeslot";
            requestsTable.Columns["WorkshopTimeslot"].Width = 120;
            #endregion
        }

        public void RefreshWorkshopsTableData()
        {
            requestsList.Clear();

            var statusSortOrder = new List<int> { 3, 1, 2 };

            var allWorkshopRequests = dbContext.WorkshopRequests
                .Where(u => u.UserId == CurrentUser.user.UserId)
                .Include(u => u.User)
                .Include(s => s.Saloon)
                .Include(c => c.Category)
                .Include(w => w.WorkshopTimeslot)
                .Include(s => s.Status)
                .AsEnumerable()
                .OrderBy(r => statusSortOrder.IndexOf(r.StatusId))
                .ThenBy(r => r.Date)
                .ToList();

            foreach (var workshopRequest in allWorkshopRequests)
            {
                requestsList.Add(new WorkshopRequestData
                {
                    WorkshopRequestId = workshopRequest.WorkshopRequestId,
                    UserId = workshopRequest.UserId,
                    SaloonId = workshopRequest.SaloonId,
                    CategoryId = workshopRequest.CategoryId,
                    WorkshopTimeslotId = workshopRequest.WorkshopTimeslotId,
                    statusId = workshopRequest.StatusId,
                    Date = workshopRequest.Date,

                    User = workshopRequest.User.Username,
                    Saloon = workshopRequest.Saloon.SaloonName,
                    Category = workshopRequest.Category.CategoryName,
                    WorkshopTimeslot = $"{workshopRequest.WorkshopTimeslot.StartTime} - {workshopRequest.WorkshopTimeslot.EndTime}",
                    Status = workshopRequest.Status.StatusName,
                });
            }

            requestsTable.Refresh();
        }

        public class WorkshopRequestData
        {
            public int WorkshopRequestId { get; set; }
            public int UserId { get; set; }
            public int SaloonId { get; set; }
            public int CategoryId { get; set; }
            public int WorkshopTimeslotId { get; set; }
            public int statusId { get; set; }
            public DateTime Date { get; set; }

            public string User { get; set; }
            public string Saloon { get; set; }
            public string Category { get; set; }
            public string WorkshopTimeslot { get; set; }
            public string Status { get; set; }
        }
    }
}
