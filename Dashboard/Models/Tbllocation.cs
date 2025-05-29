using System;
using System.Collections.Generic;

namespace Dashboard.Models;

public partial class Tbllocation
{
    public int TenentId { get; set; }

    public int Locationid { get; set; }

    public string Physicallocid { get; set; } = null!;

    public string Locname1 { get; set; } = null!;

    public string Locname2 { get; set; } = null!;

    public string Locname3 { get; set; } = null!;

    public string Address { get; set; } = null!;

    public string Dept { get; set; } = null!;

    public string Sectioncode { get; set; } = null!;

    public string Account { get; set; } = null!;

    public int Maxdiscount { get; set; }

    public string Userid { get; set; } = null!;

    public DateTime Entrydate { get; set; }

    public DateTime Entrytime { get; set; }

    public DateTime Updttime { get; set; }

    public string? Active { get; set; }

    public string? Locname { get; set; }

    public string? Locnameo { get; set; }

    public string? Locnamech { get; set; }

    public long? CrupId { get; set; }

    public DateTime? UploadDate { get; set; }

    public string? Uploadby { get; set; }

    public DateTime? SyncDate { get; set; }

    public string? Syncby { get; set; }

    public int? SynId { get; set; }
}
