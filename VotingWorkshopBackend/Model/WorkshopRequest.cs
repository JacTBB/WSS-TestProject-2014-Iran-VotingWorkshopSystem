using System;
using System.Collections.Generic;

namespace VotingWorkshopBackend.Model;

public partial class WorkshopRequest
{
    public int WorkshopRequestId { get; set; }

    public int UserId { get; set; }

    public int SaloonId { get; set; }

    public int CategoryId { get; set; }

    public int WorkshopTimeslotId { get; set; }

    public int StatusId { get; set; }

    public DateTime Date { get; set; }

    public virtual Category Category { get; set; } = null!;

    public virtual Saloon Saloon { get; set; } = null!;

    public virtual Status Status { get; set; } = null!;

    public virtual User User { get; set; } = null!;

    public virtual WorkshopTimeslot WorkshopTimeslot { get; set; } = null!;
}
