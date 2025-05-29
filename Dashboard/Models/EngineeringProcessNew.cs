using System;
using System.Collections.Generic;

namespace Dashboard.Models;

public partial class EngineeringProcessNew
{
    public int Id { get; set; }

    public string? ProdCode { get; set; }

    public string? PartNum { get; set; }

    public string? PartDescription { get; set; }

    public string? UdCharacter03 { get; set; }

    public string? RevisionNum { get; set; }

    public string? EffectiveDate { get; set; }

    public string? AltMethod { get; set; }

    public string? DrgAva { get; set; }

    public string? MomStatus { get; set; }

    public string? Mtl { get; set; }

    public string? MomAvaDate { get; set; }

    public string? OpSeqAva { get; set; }

    public string? OpdAva { get; set; }

    public DateTime? MafiaStamp { get; set; }

    public bool? MafiaCreated { get; set; }

    public bool? MafiaVerified { get; set; }

    public bool? MafiaReleased { get; set; }

    public string? OpdDate { get; set; }

    public DateTime? DrawingAvailableDate { get; set; }

    public DateTime? MachiningOperationalDate { get; set; }
}
