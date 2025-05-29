using System;
using System.Collections.Generic;

namespace Dashboard.Models;

public partial class Isquery
{
    public int Id { get; set; }

    public string? Qtitle { get; set; }

    public string? Remark { get; set; }

    public string? Status { get; set; }

    public bool? Active { get; set; }

    public bool? Deleted { get; set; }

    public DateTime? CreatedDate { get; set; }

    public DateTime? CompeletedDate { get; set; }

    public int? CreatedBy { get; set; }

    public int? PersonId { get; set; }
}
