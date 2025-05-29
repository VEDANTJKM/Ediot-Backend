using System;
using System.Collections.Generic;

namespace Dashboard.Models;

public partial class FunctionMst
{
    public int TenentId { get; set; }

    public int MenuId { get; set; }

    public int? MasterId { get; set; }

    public int? ModuleId { get; set; }

    public string? MenuType { get; set; }

    public string MenuName1 { get; set; } = null!;

    public string? MenuName2 { get; set; }

    public string? MenuName3 { get; set; }

    public string? Link { get; set; }

    public string? Urloption { get; set; }

    public string? Urlrewrite { get; set; }

    public string? MenuLocation { get; set; }

    public decimal? MenuOrder { get; set; }

    public string? DocParent { get; set; }

    public long CrupId { get; set; }

    public int? Addflage { get; set; }

    public int? Editflage { get; set; }

    public int? Delflage { get; set; }

    public int? Printflage { get; set; }

    public int? Amiglobale { get; set; }

    public int? Mypersonal { get; set; }

    public string? Smalltext { get; set; }

    public DateOnly? Activetilldate { get; set; }

    public string? Iconpath { get; set; }

    public string? Commanline { get; set; }

    public int? ActiveFlag { get; set; }

    public string? Metatitle { get; set; }

    public string? Metakeyword { get; set; }

    public string? Metadescription { get; set; }

    public string? Headervisibledata { get; set; }

    public string? Headerinvisibledata { get; set; }

    public string? Footervisibledata { get; set; }

    public string? Footerinvisibledata { get; set; }

    /// <summary>
    /// This is come from REF Table where retype or sub == domain
    /// </summary>
    public int? Refid { get; set; }

    /// <summary>
    /// This is come from MYBUS Table
    /// </summary>
    public int? Mybusid { get; set; }

    public int? Lableflag { get; set; }

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

    public bool? Activemenu { get; set; }

    public DateOnly? Menudate { get; set; }
}
