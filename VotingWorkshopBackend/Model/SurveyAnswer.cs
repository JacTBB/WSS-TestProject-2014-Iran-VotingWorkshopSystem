using System;
using System.Collections.Generic;

namespace VotingWorkshopBackend.Model;

public partial class SurveyAnswer
{
    public int SurveyId { get; set; }

    public int SurveyOptionId { get; set; }

    public int UserId { get; set; }

    public virtual Survey Survey { get; set; } = null!;

    public virtual SurveyOption SurveyOption { get; set; } = null!;

    public virtual User User { get; set; } = null!;
}
