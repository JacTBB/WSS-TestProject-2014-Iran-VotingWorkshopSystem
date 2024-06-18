using System;
using System.Collections.Generic;

namespace VotingWorkshopManagement.Models;

public partial class SurveyOption
{
    public int SurveyOptionId { get; set; }

    public string SurveyOptionName { get; set; }

    public int SurveyId { get; set; }

    public virtual Survey Survey { get; set; }

    public virtual ICollection<SurveyAnswer> SurveyAnswers { get; set; } = new List<SurveyAnswer>();
}
