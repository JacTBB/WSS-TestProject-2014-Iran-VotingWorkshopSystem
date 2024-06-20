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

namespace VotingWorkshopManagement.Popups
{
    public partial class AddSurvey : Form
    {
        public static VotingWorkshopSystemContext dbContext;
        public VotingTab votingTab;
        private BindingList<OptionData> optionsList = new BindingList<OptionData>();

        public AddSurvey(VotingWorkshopSystemContext dbContext, VotingTab votingTab)
        {
            InitializeComponent();
            AddSurvey.dbContext = dbContext;
            this.votingTab = votingTab;

            optionsList.AllowNew = true;
            optionsTable.DataSource = optionsList;
            optionsTable.AllowUserToAddRows = true;

            //TODO: Restrict DateTimePicker MinDate
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            var Name = txtName.Text;
            var Question = txtQuestion.Text;
            var StartDate = dateStart.Value;
            var EndDate = dateEnd.Value;

            if (Name.IsNullOrEmpty() || Question.IsNullOrEmpty())
            {
                MessageBox.Show("Missing Inputs!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (EndDate.Date < StartDate.Date)
            {
                MessageBox.Show("End Date is before Start Date!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (optionsList.Count < 2)
            {
                MessageBox.Show("Too little choices!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var survey = new Survey
            {
                SurveyName = Name,
                Question = Question,
                StartDate = StartDate,
                EndDate = EndDate,
            };
            dbContext.Add(survey);

            foreach (var option in optionsList)
            {
                var surveyOption = new SurveyOption
                {
                    SurveyOptionName = option.Option
                };
                surveyOption.Survey = survey;
                dbContext.Add(surveyOption);
            }

            dbContext.SaveChanges();

            votingTab.RefreshSurveysTableData();

            MessageBox.Show("Survey Added", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.Close();
        }

        private class OptionData
        {
            public string Option { get; set; }
        }
    }
}
