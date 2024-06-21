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

namespace VotingWorkshopManagement.Popups
{
    public partial class VoteSurvey : Form
    {
        public static VotingWorkshopSystemContext dbContext = new VotingWorkshopSystemContext();
        private SurveyTab.SurveyData surveyData;

        public VoteSurvey(SurveyTab.SurveyData surveyData)
        {
            InitializeComponent();
            this.surveyData = surveyData;

            txtName.Text = surveyData.Name;
            txtQuestion.Text = surveyData.Question;

            comboOptions.DataSource = dbContext.SurveyOptions
                .Where(o => o.SurveyId == surveyData.Id)
                .Select(o => o.SurveyOptionName)
                .ToList();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            var surveyAnswer = new SurveyAnswer
            {
                SurveyId = surveyData.Id,
                UserId = CurrentUser.user.UserId,
                SurveyOptionId = dbContext.SurveyOptions.FirstOrDefault(o => o.SurveyOptionName == comboOptions.SelectedItem.ToString()).SurveyOptionId
            };
            dbContext.Add(surveyAnswer);
            dbContext.SaveChanges();

            MessageBox.Show("Survey Voted", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }
    }
}
