using System;
using System.Collections.Generic;

namespace Dashboard.Models;

public partial class AttachmentMst
{
    public int Id { get; set; }

    public int Mid { get; set; }

    public int? EmployeeId { get; set; }

    public int? Userid { get; set; }

    public string? AttachedFileName { get; set; }

    public DateTime? AttachmentDate { get; set; }

    public string? FileName { get; set; }

    public string? Title { get; set; }

    public string? Approval { get; set; }

    public string? AttachmentType { get; set; }

    public int? EpoNo { get; set; }
}
