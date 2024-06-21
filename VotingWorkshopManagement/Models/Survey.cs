using System;
using System.Collections.Generic;

namespace VotingWorkshopManagement.Models;

public partial class Survey
{
    public int SurveyId { get; set; }

    public string SurveyName { get; set; }

    public string Question { get; set; }

    public DateTime StartDate { get; set; }

    public DateTime EndDate { get; set; }

    public bool Active { get; set; }

    public virtual ICollection<SurveyAnswer> SurveyAnswers { get; set; } = new List<SurveyAnswer>();

    public virtual ICollection<SurveyOption> SurveyOptions { get; set; } = new List<SurveyOption>();
}
