using System;
using System.Collections.Generic;

namespace Dashboard.Models;

public partial class CrupMst
{
    public int TenantId { get; set; }

    public long CrupId { get; set; }

    public int? MySerial { get; set; }

    public int? MenuId { get; set; }

    public string? Physicallocid { get; set; }

    public string? ActivityNote { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime CreatedDt { get; set; }

    public string? UpdatedBy { get; set; }

    public DateTime? UpdatedDt { get; set; }

    public string? ActivityType { get; set; }

    public int? UserId { get; set; }

    public string? TableName { get; set; }

    public string? Url { get; set; }
}
