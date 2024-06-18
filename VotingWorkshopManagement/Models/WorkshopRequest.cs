using System;
using System.Collections.Generic;

namespace VotingWorkshopManagement.Models;

public partial class WorkshopRequest
{
    public int WorkshopRequestId { get; set; }

    public int UserId { get; set; }

    public int SaloonId { get; set; }

    public int CategoryId { get; set; }

    public int WorkshopTimeslotId { get; set; }

    public int StatusId { get; set; }

    public DateTime Date { get; set; }

    public DateTime LastUpdated { get; set; }

    public virtual Category Category { get; set; }

    public virtual Saloon Saloon { get; set; }

    public virtual Status Status { get; set; }

    public virtual User User { get; set; }

    public virtual WorkshopTimeslot WorkshopTimeslot { get; set; }
}
