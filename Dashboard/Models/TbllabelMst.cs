using System;
using System.Collections.Generic;

namespace Dashboard.Models;

public partial class TbllabelMst
{
    public int Id { get; set; }

    public int? LocationId { get; set; }

    public string? TableName { get; set; }

    public string? PageName { get; set; }

    public string? PageTitle { get; set; }

    public string? Remark { get; set; }

    public string? MySysName { get; set; }

    public int? TotalLang { get; set; }

    public int? TenantId { get; set; }

    public int? UserId { get; set; }

    public long? CrupId { get; set; }

    public DateTime? DateTime { get; set; }

    public bool? Active { get; set; }

    public bool? IsExclusive { get; set; }

    public DateTime? Updated { get; set; }
}
