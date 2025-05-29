using System;
using System.Collections.Generic;

namespace Dashboard.Models;

public partial class ModuleMap
{
    public int TenentId { get; set; }

    public int PrivilegeId { get; set; }

    public int LocationId { get; set; }

    public int ModuleId { get; set; }

    public int ModuleMapId { get; set; }

    public int UserId { get; set; }

    public string? ActiveFlag { get; set; }

    public int? TenantId { get; set; }

    public long? CrupId { get; set; }

    public int? MySerial { get; set; }

    public string? AllFlag { get; set; }

    public string? AddFlag { get; set; }

    public string? ModifyFlag { get; set; }

    public string? DeleteFlag { get; set; }

    public string? ViewFlag { get; set; }

    public int? Sp1 { get; set; }

    public int? Sp2 { get; set; }

    public int? Sp3 { get; set; }

    public int? Sp4 { get; set; }

    public int? Sp5 { get; set; }

    public string? Sp1name { get; set; }

    public string? Sp2name { get; set; }

    public string? Sp3name { get; set; }

    public string? Sp4name { get; set; }

    public string? Sp5name { get; set; }

    public string? AppVer { get; set; }

    public DateTime? AppVerDate { get; set; }

    public string? Dbver { get; set; }

    public DateTime? DbverDate { get; set; }
}
