using System;
using System.Collections.Generic;

namespace VotingWorkshopManagement.Models;

public partial class User
{
    public int UserId { get; set; }

    public int UserTypeId { get; set; }

    public string Username { get; set; }

    public string Password { get; set; }

    public string FullName { get; set; }

    public string Tel { get; set; }

    public virtual ICollection<SurveyAnswer> SurveyAnswers { get; set; } = new List<SurveyAnswer>();

    public virtual UserType UserType { get; set; }

    public virtual ICollection<WorkshopRequest> WorkshopRequests { get; set; } = new List<WorkshopRequest>();
}
