using System;
using System.Collections.Generic;

namespace VotingWorkshopManagement.Models;

public partial class Status
{
    public int StatusId { get; set; }

    public string StatusName { get; set; }

    public virtual ICollection<WorkshopRequest> WorkshopRequests { get; set; } = new List<WorkshopRequest>();
}
