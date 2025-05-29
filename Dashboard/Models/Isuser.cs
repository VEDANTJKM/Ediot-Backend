using System;
using System.Collections.Generic;

namespace Dashboard.Models;

public partial class Isuser
{
    public int Id { get; set; }

    public int? UserId { get; set; }

    public string? UserName { get; set; }

    public string? Password { get; set; }

    public int? UserType { get; set; }

    public string? PreviousQuantity { get; set; }

    public bool? Active { get; set; }

    public bool? Deleted { get; set; }

    public DateTime? CreatedDate { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? ModifyDate { get; set; }

    public int? ModifyBy { get; set; }
}
