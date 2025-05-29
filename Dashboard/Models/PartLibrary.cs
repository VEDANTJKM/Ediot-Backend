using System;
using System.Collections.Generic;

namespace Dashboard.Models;

public partial class PartLibrary
{
    public int Id { get; set; }

    public int Pid { get; set; }

    public int Rid { get; set; }

    public string TypeOfDoc { get; set; } = null!;

    public string? PartType { get; set; }

    public string? PartSubType { get; set; }

    public string? PartSubSubType { get; set; }

    public string? PartName { get; set; }

    public string? OpNo { get; set; }

    public string? Attachment { get; set; }

    public string? MachineName { get; set; }

    public string? TypeOfOp { get; set; }

    public DateTime? DrawingRevisionDate { get; set; }

    public int? DrawingRevisionNo { get; set; }

    public int? UploadedRevisionNo { get; set; }

    public string? PartStartName { get; set; }

    public string? CurrentHistory { get; set; }

    public string? DraRevNo { get; set; }

    public string? Approved { get; set; }

    public DateTime? ApprovalDate { get; set; }

    public string? CreatedBy { get; set; }

    public string? ApprovalComment { get; set; }

    public string? Attchment2 { get; set; }

    public string? Jobno { get; set; }

    public string? PoNo { get; set; }

    public string? ApprovedBy { get; set; }

    public string? Attachment2 { get; set; }

    public string? MachineNo { get; set; }

    public string? Attachment3 { get; set; }

    public string? Attachment4 { get; set; }

    public bool? Active { get; set; }
}
