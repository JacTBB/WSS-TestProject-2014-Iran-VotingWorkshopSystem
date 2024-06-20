using Microsoft.IdentityModel.Tokens;
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
    public partial class RequestTab : Form
    {
        public static VotingWorkshopSystemContext dbContext;

        public RequestTab(VotingWorkshopSystemContext dbContext)
        {
            InitializeComponent();
            RequestTab.dbContext = dbContext;

            SetupComboPickers();
        }

        private void SetupComboPickers()
        {
            comboSaloon.DataSource = dbContext.Saloons.Select(s => s.SaloonName).ToList();
            comboCategory.DataSource = dbContext.Categories.Select(c => c.CategoryName).ToList();
            comboTimeslot.DataSource = dbContext.WorkshopTimeslots.Select(t => $"{t.StartTime} - {t.EndTime}").ToList();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            var saloon = comboSaloon.SelectedItem.ToString();
            var category = comboCategory.SelectedItem.ToString();
            var timeslot = comboTimeslot.SelectedItem.ToString();
            var date = datePicker.Value;

            if (saloon.IsNullOrEmpty() || category.IsNullOrEmpty() || timeslot.IsNullOrEmpty())
            {
                MessageBox.Show("Missing Inputs!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var saloonData = dbContext.Saloons.FirstOrDefault(s => s.SaloonName == saloon);
            var categoryData = dbContext.Categories.FirstOrDefault(c => c.CategoryName == category);
            var timeslotData = dbContext.WorkshopTimeslots.AsEnumerable().FirstOrDefault(t => $"{t.StartTime} - {t.EndTime}" == timeslot);

            var workshopRequest = new WorkshopRequest
            {
                UserId = CurrentUser.user.UserId,
                SaloonId = saloonData.SaloonId,
                CategoryId = categoryData.CategoryId,
                WorkshopTimeslotId = timeslotData.WorkshopTimeslotId,
                Date = date,
                LastUpdated = DateTime.Now,
                StatusId = 3,
            };
            dbContext.Add(workshopRequest);
            dbContext.SaveChanges();

            MessageBox.Show("Workshop Request Sent", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
