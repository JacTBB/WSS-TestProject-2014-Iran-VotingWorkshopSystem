using System;
using System.Collections.Generic;

namespace VotingWorkshopBackend.Model;

public partial class UserType
{
    public int UserTypeId { get; set; }

    public string UserTypeName { get; set; } = null!;

    public virtual ICollection<User> Users { get; set; } = new List<User>();
}
