using System;
using System.Collections.Generic;

namespace Dashboard.Models;

public partial class ModuleMst
{
    public int TenentId { get; set; }

    public int ModuleId { get; set; }

    public string? Mysysname { get; set; }

    public string ModuleName { get; set; } = null!;

    public string? ModuleNameO { get; set; }

    public string? ModuleNameT { get; set; }

    public string? ModuleDesc { get; set; }

    public int? ParentModuleId { get; set; }

    public int? ModuleOrder { get; set; }

    public string? ActiveFlag { get; set; }

    public long CrupId { get; set; }

    /// <summary>
    /// UP ,Left , Down,Top Ayo 
    /// </summary>
    public string? ModuleLocation { get; set; }

    public bool? Activemodule { get; set; }

    public DateOnly? Moduledate { get; set; }

    public string? AppVer { get; set; }

    public DateTime? AppVerDate { get; set; }

    public string? Dbver { get; set; }

    public DateTime? DbverDate { get; set; }

    public string? AppDownLoadUrl { get; set; }

    public string? ConStr { get; set; }

    public string? Suser { get; set; }

    public string? Spass { get; set; }
}
