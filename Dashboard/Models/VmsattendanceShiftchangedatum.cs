using System;
using System.Collections.Generic;

namespace Dashboard.Models;

public partial class VmsattendanceShiftchangedatum
{
    public int Id { get; set; }

    public int Mid { get; set; }

    public int Pid { get; set; }

    public string? PersonId { get; set; }

    public string? PersonName { get; set; }

    public string? Organization { get; set; }

    public string? CurrentShift { get; set; }

    public string? ChangeShift { get; set; }

    public bool? ApproveBySupervisor { get; set; }

    public bool? ApproveByHr { get; set; }

    public bool? Active { get; set; }

    public DateTime? UploadDate { get; set; }

    public DateTime? ApproveDateSupervisor { get; set; }

    public DateTime? ApproveDateHr { get; set; }

    public string? CurrentOffday { get; set; }

    public string? ChangeOffday { get; set; }
}
