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
using System.Windows.Forms.DataVisualization.Charting;
using VotingWorkshopManagement.Models;
using VotingWorkshopManagement.Popups;

namespace VotingWorkshopManagement
{
    public partial class ResultsTab : Form
    {
        public static VotingWorkshopSystemContext dbContext;
        public BindingList<SurveyData> surveysList = new BindingList<SurveyData>();

        public ResultsTab(VotingWorkshopSystemContext dbContext)
        {
            InitializeComponent();
            ResultsTab.dbContext = dbContext;

            RefreshSurveysTableData();

            #region Configure SurveysTable
            surveysTable.DataSource = surveysList;
            surveysTable.AllowUserToAddRows = false;
            surveysTable.MultiSelect = false;
            surveysTable.RowHeadersVisible = false;
            surveysTable.Columns["Id"].Visible = false;
            surveysTable.Columns["Question"].Visible = false;

            DataGridViewButtonColumn viewButtonColumn = new DataGridViewButtonColumn();
            viewButtonColumn.Name = "View";
            viewButtonColumn.Text = "View";
            viewButtonColumn.UseColumnTextForButtonValue = true;
            surveysTable.Columns.Add(viewButtonColumn);
            #endregion
        }

        private void surveysTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            if (surveysTable.Columns[e.ColumnIndex].Name == "View")
            {
                var rowData = surveysTable.Rows[e.RowIndex].DataBoundItem as SurveyData;
                if (rowData != null)
                {
                    txtName.Text = rowData.Name;
                    txtQuestion.Text = rowData.Question;
                    txtStartDate.Text = rowData.StartDate.Date.ToString();
                    txtEndDate.Text = rowData.EndDate.Date.ToString();

                    var allAnswers = dbContext.SurveyAnswers
                        .Include(o => o.SurveyOption)
                        .Where(a => a.SurveyId == rowData.Id)
                        .GroupBy(a => a.SurveyOptionId)
                        .ToList();

                    Series series = new Series();
                    series.Name = "Survey Options";
                    series.ChartType = SeriesChartType.Pie;

                    foreach (var answer in allAnswers)
                    {
                        series.Points.AddXY(answer.First().SurveyOption.SurveyOptionName, answer.Count());
                    }

                    chartResults.Series.Clear();
                    chartResults.Series.Add(series);
                }
            }
        }

        public void RefreshSurveysTableData()
        {
            surveysList.Clear();

            var allSurveys = dbContext.Surveys
                .Where(a => a.Active == true)
                .OrderBy(d => d.EndDate)
                .ToList();

            foreach (var survey in allSurveys)
            {
                surveysList.Add(new SurveyData
                {
                    Id = survey.SurveyId,
                    Name = survey.SurveyName,
                    Question = survey.Question,
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
            public DateTime StartDate { get; set; }
            public DateTime EndDate { get; set; }
        }
    }
}
