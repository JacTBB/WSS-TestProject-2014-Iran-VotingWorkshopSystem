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
    public partial class SurveyTab : Form
    {
        public static VotingWorkshopSystemContext dbContext = new VotingWorkshopSystemContext();
        public BindingList<SurveyData> surveysList = new BindingList<SurveyData>();

        public SurveyTab(VotingWorkshopSystemContext dbcontext)
        {
            InitializeComponent();

            RefreshSurveysTableData();

            #region Configure SurveysTable
            surveysTable.DataSource = surveysList;
            surveysTable.AllowUserToAddRows = false;
            surveysTable.MultiSelect = false;
            surveysTable.RowHeadersVisible = false;

            DataGridViewButtonColumn voteButtonColumn = new DataGridViewButtonColumn();
            voteButtonColumn.Name = "Vote";
            voteButtonColumn.Text = "Vote";
            voteButtonColumn.UseColumnTextForButtonValue = true;
            surveysTable.Columns.Add(voteButtonColumn);

            surveysTable.CellFormatting += new DataGridViewCellFormattingEventHandler(surveysTable_CellFormatting);
            #endregion
        }

        private void surveysTable_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (surveysTable.Columns[e.ColumnIndex].Name == "Vote" && e.RowIndex >= 0)
            {
                var rowData = surveysTable.Rows[e.RowIndex].DataBoundItem as SurveyData;
                if (rowData != null)
                {
                    if (rowData.Voted != "No")
                    {
                        e.Value = DBNull.Value;
                    }
                }
            }
        }

        private void surveysTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            if (surveysTable.Columns[e.ColumnIndex].Name == "Vote")
            {
                var rowData = surveysTable.Rows[e.RowIndex].DataBoundItem as SurveyData;
                if (rowData == null) return;
                if (rowData.Voted == "Yes") return;

                Form popup = new VoteSurvey(rowData)
                {
                    TopLevel = true,
                    AutoScroll = false,
                    FormBorderStyle = FormBorderStyle.FixedSingle,
                };
                popup.ShowDialog(this);
            }
        }

        public void RefreshSurveysTableData()
        {
            surveysList.Clear();

            var allSurveys = dbContext.Surveys
                .Where(a => a.Active == true)
                .Where(d => d.StartDate.Date < DateTime.Now.Date)
                .Where(d => d.EndDate.Date >= DateTime.Now.Date)
                .OrderBy(d => d.EndDate)
                .ToList();

            foreach (var survey in allSurveys)
            {
                var votedData = dbContext.SurveyAnswers
                    .Where(a => a.SurveyId == survey.SurveyId)
                    .Where(u => u.UserId == CurrentUser.user.UserId)
                    .Include(o => o.SurveyOption)
                    .ToList();

                var voted = "No";
                if (votedData.Count > 0)
                {
                    voted = votedData[0].SurveyOption.SurveyOptionName;
                }

                surveysList.Add(new SurveyData
                {
                    Id = survey.SurveyId,
                    Name = survey.SurveyName,
                    Question = survey.Question,
                    Voted = voted,
                    StartDate = survey.StartDate,
                    EndDate = survey.EndDate,
                });
            }
        }

        public class SurveyData
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public string Question { get; set; }
            public string Voted { get; set; }
            public DateTime StartDate { get; set; }
            public DateTime EndDate { get; set; }
        }
    }
}
