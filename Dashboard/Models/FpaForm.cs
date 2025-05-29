using System;
using System.Collections.Generic;

namespace Dashboard.Models;

public partial class FpaForm
{
    public int Id { get; set; }

    public int? GroupId { get; set; }

    public int? LineId { get; set; }

    public string? JobNo { get; set; }

    public string? MachineNo { get; set; }

    public DateTime? Date { get; set; }

    public string? PartNo { get; set; }

    public string? ProgrammerName { get; set; }

    public string? Shift { get; set; }

    public string? DrawingRevision { get; set; }

    public string? SupervisorName { get; set; }

    public string? Operation { get; set; }

    public string? InspectorName { get; set; }

    public TimeOnly? StartTime { get; set; }

    public TimeOnly? EndTime { get; set; }

    public bool? HeatTreatmentSlugRequired { get; set; }

    public string? SupervisorSign { get; set; }

    public string? ProgSign { get; set; }

    public string? QiStampSign { get; set; }

    public string? MaterialDrawingRequired { get; set; }

    public string? MaterialColorCode { get; set; }

    public string? IssuedMaterialColorCode { get; set; }

    public string? IsueMaterialPartno { get; set; }

    public string? IssuedMaterialPartLot { get; set; }

    public string? IssuedMaterialDescription { get; set; }

    public string? Partweight { get; set; }

    public string? PartSqrncode { get; set; }

    public string? InformationVerifiedByQi { get; set; }

    public string? SetupSheetUploaded { get; set; }

    public string? ProgramUploaded { get; set; }

    public bool? IsDelete { get; set; }

    public bool? IsSaved { get; set; }

    public bool? Inch { get; set; }

    public bool? Mm { get; set; }
}
