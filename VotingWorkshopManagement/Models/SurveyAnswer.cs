using System;
using System.Collections.Generic;

namespace VotingWorkshopManagement.Models;

public partial class SurveyAnswer
{
    public int SurveyId { get; set; }

    public int SurveyOptionId { get; set; }

    public int UserId { get; set; }

    public virtual Survey Survey { get; set; }

    public virtual SurveyOption SurveyOption { get; set; }

    public virtual User User { get; set; }
}
