using System;
using System.Collections.Generic;

namespace Dashboard.Models;

public partial class PrivilageMenudemon
{
    public int PrivilegeMenuId { get; set; }

    public int TenentId { get; set; }

    public int PrivilegeId { get; set; }

    public int Privilagefor { get; set; }

    public int LocationId { get; set; }

    public int MenuId { get; set; }

    public string? IsVisible { get; set; }

    public string? IsEnable { get; set; }

    public string? ActiveFlag { get; set; }

    public long? CrupId { get; set; }

    public int MySerial { get; set; }

    public string? AllFlag { get; set; }

    public string? AddFlag { get; set; }

    public string? ModifyFlag { get; set; }

    public string? DeleteFlag { get; set; }

    public string? ViewFlag { get; set; }

    public string? LabelFlag { get; set; }

    public int? MasterId { get; set; }

    public string? MenuLocation { get; set; }

    public DateOnly? Activetilldate { get; set; }

    public DateTime? LastUpdate { get; set; }

    public DateTime? CreatedDate { get; set; }

    public string? Sp1 { get; set; }

    public string? Sp2 { get; set; }

    public string? Sp3 { get; set; }

    public string? Sp4 { get; set; }

    public string? Sp5 { get; set; }

    public string? Sp1name { get; set; }

    public string? Sp2name { get; set; }

    public string? Sp3name { get; set; }

    public string? Sp4name { get; set; }

    public string? Sp5name { get; set; }

    public string? ActiveMenu { get; set; }

    public string? ActiveModule { get; set; }

    public string? Action { get; set; }
}
