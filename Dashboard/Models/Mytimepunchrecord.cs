using System;
using System.Collections.Generic;

namespace Dashboard.Models;

public partial class Mytimepunchrecord
{
    public int Id { get; set; }

    public int Pid { get; set; }

    public int? PersonId { get; set; }

    public string? Personname { get; set; }

    public DateTime? Date { get; set; }

    public string? Status { get; set; }

    public TimeOnly? Time { get; set; }

    public DateTime? Datetime { get; set; }

    public string? Approval { get; set; }

    public string? Active { get; set; }

    public string? NewAdded { get; set; }
}
