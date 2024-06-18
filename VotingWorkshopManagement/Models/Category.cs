using System;
using System.Collections.Generic;

namespace VotingWorkshopManagement.Models;

public partial class Category
{
    public int CategoryId { get; set; }

    public string CategoryName { get; set; }

    public virtual ICollection<WorkshopRequest> WorkshopRequests { get; set; } = new List<WorkshopRequest>();
}
