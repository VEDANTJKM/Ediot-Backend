using System;
using System.Collections.Generic;

namespace Dashboard.Models;

public partial class EngineeringProcess
{
    public int Id { get; set; }

    public string? PartProdCode { get; set; }

    public string? PartPartNum { get; set; }

    public string? PartUdCharacter03 { get; set; }

    public string? PartRevRevisionNum { get; set; }

    public string? PartRevEffectiveDate { get; set; }

    public string? PartRevAltMethod { get; set; }

    public string? CalculatedDrgAva { get; set; }

    public string? CalculatedMomStatus { get; set; }

    public string? CalculatedMtl { get; set; }

    public string? CalculatedMomAvaDate { get; set; }

    public string? CalculatedOpSeqAva { get; set; }

    public string? CalculatedOpdAva { get; set; }
}
