﻿using System;
using System.Collections.Generic;

namespace VotingWorkshopBackend.Model;

public partial class User
{
    public int UserId { get; set; }

    public int UserTypeId { get; set; }

    public string Username { get; set; } = null!;

    public string Password { get; set; } = null!;

    public string? FullName { get; set; }

    public string? Tel { get; set; }

    public virtual ICollection<SurveyAnswer> SurveyAnswers { get; set; } = new List<SurveyAnswer>();

    public virtual UserType UserType { get; set; } = null!;

    public virtual ICollection<WorkshopRequest> WorkshopRequests { get; set; } = new List<WorkshopRequest>();
}
