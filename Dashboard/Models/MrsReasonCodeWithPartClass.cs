using System;
using System.Collections.Generic;

namespace Dashboard.Models;

public partial class MrsReasonCodeWithPartClass
{
    public int Id { get; set; }

    public string? ClassId { get; set; }

    public string? ClassDescription { get; set; }

    public string? ReasonCode { get; set; }

    public string? ReasonCodeDescription { get; set; }

    public bool? IsActive { get; set; }
}
