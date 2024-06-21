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
using VotingWorkshopManagement.Popups;

namespace VotingWorkshopManagement
{
    public partial class VotingTab : Form
    {
        public static VotingWorkshopSystemContext dbContext;
        public BindingList<SurveyData> surveysList = new BindingList<SurveyData>();
        public BindingSource surveysBindingSource;

        public VotingTab(VotingWorkshopSystemContext dbContext)
        {
            InitializeComponent();
            VotingTab.dbContext = dbContext;
            surveysBindingSource = new BindingSource { DataSource = surveysList };

            RefreshSurveysTableData();

            #region Configure UsersTable
            surveysTable.DataSource = surveysBindingSource;
            surveysTable.AllowUserToAddRows = false;
            surveysTable.MultiSelect = false;
            surveysTable.RowHeadersVisible = false;
            surveysTable.Columns["Options"].Width = 200;

            DataGridViewButtonColumn approveButtonColumn = new DataGridViewButtonColumn();
            approveButtonColumn.Name = "Activate";
            approveButtonColumn.Text = "Activate";
            approveButtonColumn.UseColumnTextForButtonValue = true;
            surveysTable.Columns.Add(approveButtonColumn);

            DataGridViewButtonColumn rejectButtonColumn = new DataGridViewButtonColumn();
            rejectButtonColumn.Name = "Deactivate";
            rejectButtonColumn.Text = "Deactivate";
            rejectButtonColumn.UseColumnTextForButtonValue = true;
            surveysTable.Columns.Add(rejectButtonColumn);

            surveysTable.CellFormatting += new DataGridViewCellFormattingEventHandler(surveysTable_CellFormatting);
            #endregion
        }

        private void surveysTable_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (surveysTable.Columns[e.ColumnIndex].Name == "Activate" && e.RowIndex >= 0)
            {
                var rowData = surveysTable.Rows[e.RowIndex].DataBoundItem as SurveyData;
                if (rowData != null)
                {
                    if (rowData.Active == "Yes")
                    {
                        e.Value = DBNull.Value;
                    }
                }
            }
            if (surveysTable.Columns[e.ColumnIndex].Name == "Deactivate" && e.RowIndex >= 0)
            {
                var rowData = surveysTable.Rows[e.RowIndex].DataBoundItem as SurveyData;
                if (rowData != null)
                {
                    if (rowData.Active == "No")
                    {
                        e.Value = DBNull.Value;
                    }
                }
            }
        }

        private void surveysTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            if (surveysTable.Columns[e.ColumnIndex].Name == "Activate")
            {
                var rowData = surveysTable.Rows[e.RowIndex].DataBoundItem as SurveyData;
                if (rowData == null) return;
                if (rowData.Active == "Yes") return;

                var survey = dbContext.Surveys.FirstOrDefault(s => s.SurveyId == rowData.SurveyId);
                if (survey == null) return;

                survey.Active = true;
                dbContext.SaveChanges();

                rowData.Active = "Yes";
                RefreshSurveysTableData();
                surveysTable.Refresh();

                MessageBox.Show("Activated", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            if (surveysTable.Columns[e.ColumnIndex].Name == "Deactivate")
            {
                var rowData = surveysTable.Rows[e.RowIndex].DataBoundItem as SurveyData;
                if (rowData == null) return;
                if (rowData.Active == "No") return;

                var survey = dbContext.Surveys.FirstOrDefault(s => s.SurveyId == rowData.SurveyId);
                if (survey == null) return;

                survey.Active = false;
                dbContext.SaveChanges();

                rowData.Active = "No";
                RefreshSurveysTableData();
                surveysTable.Refresh();

                MessageBox.Show("Deactivated", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public void RefreshSurveysTableData()
        {
            surveysList.Clear();

            var allSurveys = dbContext.Surveys
                .Include(o => o.SurveyOptions)
                .ToList();

            foreach (var survey in allSurveys)
            {
                string SurveyOptions = "";
                string Active = "No";

                if (survey.Active == true)
                {
                    Active = "Yes";
                }

                foreach (var option in survey.SurveyOptions)
                {
                    SurveyOptions += $" - {option.SurveyOptionName}";
                }

                surveysList.Add(new SurveyData
                {
                    SurveyId = survey.SurveyId,
                    SurveyName = survey.SurveyName,
                    Question = survey.Question,
                    StartDate = survey.StartDate.Date,
                    Active = Active,
                    EndDate = survey.EndDate.Date,
                    Options = SurveyOptions
                });
            }

            surveysTable.Refresh();
        }

        public class SurveyData
        {
            public int SurveyId { get; set; }
            public string SurveyName { get; set; }
            public string Question { get; set; }
            public DateTime StartDate { get; set; }
            public DateTime EndDate { get; set; }
            public string Active { get; set; }
            public string Options { get; set; }
        }

        private void btnAddSurvey_Click(object sender, EventArgs e)
        {
            Form popup = new AddSurvey(dbContext, this)
            {
                TopLevel = true,
                AutoScroll = false,
                FormBorderStyle = FormBorderStyle.FixedSingle,
            };
            popup.ShowDialog(this);
        }
    }
}
