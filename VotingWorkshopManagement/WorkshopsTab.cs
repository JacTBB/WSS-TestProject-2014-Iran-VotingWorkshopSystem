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

namespace VotingWorkshopManagement
{
    public partial class WorkshopsTab : Form
    {
        public static VotingWorkshopSystemContext dbContext;
        public BindingList<WorkshopRequestData> workshopRequestsList = new BindingList<WorkshopRequestData>();
        public BindingSource workshopRequestsBindingSource;

        public WorkshopsTab(VotingWorkshopSystemContext dbContext)
        {
            InitializeComponent();
            WorkshopsTab.dbContext = dbContext;
            workshopRequestsBindingSource = new BindingSource { DataSource = workshopRequestsList };

            RefreshWorkshopsTableData();

            #region Configure WorkshopsTable
            workshopsTable.DataSource = workshopRequestsBindingSource;
            workshopsTable.AllowUserToAddRows = false;
            workshopsTable.MultiSelect = false;
            workshopsTable.RowHeadersVisible = false;
            workshopsTable.Columns["WorkshopRequestId"].Visible = false;
            workshopsTable.Columns["UserId"].Visible = false;
            workshopsTable.Columns["SaloonId"].Visible = false;
            workshopsTable.Columns["CategoryId"].Visible = false;
            workshopsTable.Columns["WorkshopTimeslotId"].Visible = false;
            workshopsTable.Columns["StatusId"].Visible = false;

            workshopsTable.Columns["WorkshopTimeslot"].HeaderText = "Workshop Timeslot";
            workshopsTable.Columns["WorkshopTimeslot"].Width = 120;

            DataGridViewButtonColumn approveButtonColumn = new DataGridViewButtonColumn();
            approveButtonColumn.Name = "Approve";
            approveButtonColumn.Text = "Approve";
            approveButtonColumn.UseColumnTextForButtonValue = true;
            workshopsTable.Columns.Add(approveButtonColumn);

            workshopsTable.CellFormatting += new DataGridViewCellFormattingEventHandler(workshopsTable_CellFormatting);
            #endregion
        }

        private void workshopsTable_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (workshopsTable.Columns[e.ColumnIndex].Name == "Approve" && e.RowIndex >= 0)
            {
                var rowData = workshopsTable.Rows[e.RowIndex].DataBoundItem as WorkshopRequestData;
                if (rowData != null)
                {
                    if (rowData.statusId != 3)
                    {
                        e.Value = DBNull.Value;
                    }
                }
            }
        }

        private void workshopsTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            if (workshopsTable.Columns[e.ColumnIndex].Name == "Approve")
            {
                var rowData = workshopsTable.Rows[e.RowIndex].DataBoundItem as WorkshopRequestData;
                if (rowData == null) return;

                var workshopRequest = dbContext.WorkshopRequests.FirstOrDefault(r => r.WorkshopRequestId == rowData.WorkshopRequestId);
                if (workshopRequest == null) return;

                //TODO: Reject other requests for same date, time, saloon, user
                workshopRequest.StatusId = 1;
                dbContext.SaveChanges();

                rowData.statusId = 1;
                rowData.Status = dbContext.Statuses.First(s => s.StatusId == 1).StatusName;
                RefreshWorkshopsTableData();
                workshopsTable.Refresh();

                MessageBox.Show("Approved", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
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

        private void RefreshWorkshopsTableData()
        {
            var statusSortOrder = new List<int> { 3, 1, 2 };

            var allWorkshopRequests = dbContext.WorkshopRequests
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
                workshopRequestsList.Add(new WorkshopRequestData
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

            workshopsTable.Refresh();
        }
    }
}
