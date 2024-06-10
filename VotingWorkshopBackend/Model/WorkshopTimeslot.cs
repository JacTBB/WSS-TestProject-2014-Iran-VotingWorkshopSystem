using System;
using System.Collections.Generic;

namespace VotingWorkshopBackend.Model;

public partial class WorkshopTimeslot
{
    public int WorkshopTimeslotId { get; set; }

    public TimeSpan StartTime { get; set; }

    public TimeSpan EndTime { get; set; }

    public virtual ICollection<WorkshopRequest> WorkshopRequests { get; set; } = new List<WorkshopRequest>();
}
