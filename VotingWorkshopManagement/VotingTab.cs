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

            //TODO: Activate/Deactivate column
            #endregion
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

                foreach (var option in survey.SurveyOptions)
                {
                    SurveyOptions += $" - {option.SurveyOptionName}";
                }

                surveysList.Add(new SurveyData
                {
                    SurveyId = survey.SurveyId,
                    SurveyName = survey.SurveyName,
                    Question = survey.Question,
                    StartDate = survey.StartDate.Value.Date,
                    EndDate = survey.EndDate.Value.Date,
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
