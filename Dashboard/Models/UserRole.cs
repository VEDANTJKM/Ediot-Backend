using System;
using System.Collections.Generic;

namespace Dashboard.Models;

public partial class UserRole
{
    public int TenentId { get; set; }

    public int UserRoleId { get; set; }

    public int PrivilegeId { get; set; }

    public int LocationId { get; set; }

    public int UserId { get; set; }

    public int RoleId { get; set; }

    public string? ActiveFlag { get; set; }

    public DateTime? ActiveFromDt { get; set; }

    public DateTime? ActiveToDt { get; set; }

    public long? CrupId { get; set; }

    public int? AllFlag { get; set; }

    public int? AddFlag { get; set; }

    public int? ModifyFlag { get; set; }

    public int? DeleteFlag { get; set; }

    public int? ViewFlag { get; set; }

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

    public string? ApplicationName { get; set; }

    public string? MenuName { get; set; }

    public DateTime? UploadDate { get; set; }

    public string? MenuIcon { get; set; }

    public string? MenuRole { get; set; }

    public string? MenuLink { get; set; }
}
