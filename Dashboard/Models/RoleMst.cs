using System;
using System.Collections.Generic;

namespace Dashboard.Models;

public partial class RoleMst
{
    public int TenentId { get; set; }

    public int RoleId { get; set; }

    public string RoleName { get; set; } = null!;

    public string? RoleName1 { get; set; }

    public string? RoleName2 { get; set; }

    public string RoleDesc { get; set; } = null!;

    public string ActiveFlag { get; set; } = null!;

    public DateTime ActiveFromDt { get; set; }

    public DateTime ActiveToDt { get; set; }

    public int? ErpTenantId { get; set; }

    public long CrupId { get; set; }

    public bool? Activerole { get; set; }

    public DateOnly? Rolldate { get; set; }
}
