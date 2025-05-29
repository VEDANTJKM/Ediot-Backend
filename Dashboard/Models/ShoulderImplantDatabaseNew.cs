using System;
using System.Collections.Generic;

namespace Dashboard.Models;

public partial class ShoulderImplantDatabaseNew
{
    public int Id { get; set; }

    public int Mid { get; set; }

    public int Pid { get; set; }

    public string ShoulderId { get; set; } = null!;

    public string? ImplantName { get; set; }

    public string? Manufacturer { get; set; }

    public string? AnatomicReverse { get; set; }

    public bool? Collar { get; set; }

    public bool? ProximalFalsetchedLip { get; set; }

    public string? Trunnion { get; set; }

    public bool? Threads { get; set; }

    public bool? InnerLip { get; set; }

    public string? StemTrunnionAngle { get; set; }

    public bool? Fins { get; set; }

    public bool? UnthreadedProximalHole { get; set; }

    public string? Stem { get; set; }

    public string? HuneralHeads { get; set; }

    public string? GlenoidGlenosphere { get; set; }

    public string? Liners { get; set; }

    public string? Other { get; set; }

    public string? StemExtractionTechniqueATools { get; set; }

    public string? StemExtractionTechniqueASteps { get; set; }

    public string? StemExtractionTechniqueBTools { get; set; }

    public string? StemExtractionTechniqueBSteps { get; set; }

    public string? StemExtractionTechniqueCTools { get; set; }

    public string? StemExtractionTechniqueCSteps { get; set; }

    public string? StemExtractionTechniqueDTools { get; set; }

    public string? StemExtractionTechniqueDSteps { get; set; }

    public string? StemExtractionTechniqueETools { get; set; }

    public string? StemExtractionTechniqueESteps { get; set; }

    public string? Link { get; set; }

    public string? Notes { get; set; }
}
