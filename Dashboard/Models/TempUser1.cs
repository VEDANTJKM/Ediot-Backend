using System;
using System.Collections.Generic;

namespace Dashboard.Models;

public partial class TempUser1
{
    public long TenentId { get; set; }

    public int Privilageid { get; set; }

    public string Privilagesource { get; set; } = null!;

    public int Menuid { get; set; }

    public int LocationId { get; set; }

    public int? PrivilageMenuid { get; set; }

    public int? ModuleId { get; set; }

    public int UserId { get; set; }

    public int RoleId { get; set; }

    public string? AddFlag { get; set; }

    public string? ModifyFlag { get; set; }

    public string? DeleteFlag { get; set; }

    public string? ViewFlag { get; set; }

    public int? Printflage { get; set; }

    public string? AllFlag { get; set; }

    public string? Link { get; set; }

    public int? MasterId { get; set; }

    public string? MenuType { get; set; }

    public string? MenuName1 { get; set; }

    public string? MenuName2 { get; set; }

    public string? MenuName3 { get; set; }

    public string? Urlrewrite { get; set; }

    public string? MenuLocation { get; set; }

    public decimal? MenuOrder { get; set; }

    public string? DocParent { get; set; }

    public int? Amiglobale { get; set; }

    public int? Mypersonal { get; set; }

    public string? Smalltext { get; set; }

    public string? Iconpath { get; set; }

    public string? Metatitle { get; set; }

    public string? Metakeyword { get; set; }

    public string? Metadescription { get; set; }

    public string? Headervisibledata { get; set; }

    public string? Headerinvisibledata { get; set; }

    public string? Footervisibledata { get; set; }

    public string? Footerinvisibledata { get; set; }

    public int? Refid { get; set; }

    public int? Mybusid { get; set; }

    public DateOnly? Activetilldate { get; set; }

    public bool? Activemenu { get; set; }

    public bool? Activeprivilage { get; set; }

    public bool? Activemodule { get; set; }

    public bool? Activerole { get; set; }

    public bool? UraddFlag { get; set; }

    public bool? UrmodifyFlag { get; set; }

    public bool? UrdeleteFlag { get; set; }

    public bool? UrviewFlag { get; set; }

    public bool? UrallFlag { get; set; }

    public bool? IsLabelUpdate { get; set; }

    public long? CrupId { get; set; }

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

    public DateOnly? Userdate { get; set; }

    public DateOnly? Menudate { get; set; }

    public bool? Activetenent { get; set; }

    public DateOnly? Tenentdate { get; set; }

    public DateOnly? Rolldate { get; set; }

    public DateOnly? Moduledate { get; set; }

    public DateOnly? Privilagedate { get; set; }

    public bool? Activeuser { get; set; }
}
