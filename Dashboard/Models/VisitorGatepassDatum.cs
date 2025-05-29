using System;
using System.Collections.Generic;

namespace Dashboard.Models;

public partial class VisitorGatepassDatum
{
    public int Id { get; set; }

    public int Pid { get; set; }

    public int Mid { get; set; }

    public int VisitorId { get; set; }

    public string? InitiatorName { get; set; }

    public string? Department { get; set; }

    public string? VisitingPersonName { get; set; }

    public DateOnly? VisitingDate { get; set; }

    public string? PersonMeet { get; set; }

    public string? VisitingTime { get; set; }

    public int? NoOfPerson { get; set; }

    public string? VisitingType { get; set; }

    public string? Purpose { get; set; }

    public DateOnly? ValidUpto { get; set; }

    public DateTime? Uploaddate { get; set; }

    public string? VGpno { get; set; }

    public int? Uploadby { get; set; }

    public string? VStatus { get; set; }

    public DateTime? InTime { get; set; }

    public DateTime? OutTime { get; set; }

    public string? ThemeColor { get; set; }

    public bool? IsFullDay { get; set; }

    public string? Representing { get; set; }

    public string? ContactNo { get; set; }
}
