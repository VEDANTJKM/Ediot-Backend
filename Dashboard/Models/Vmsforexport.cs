using System;
using System.Collections.Generic;

namespace Dashboard.Models;

public partial class Vmsforexport
{
    public int Id { get; set; }

    public string? Personid { get; set; }

    public string? Name { get; set; }

    public string? Status { get; set; }

    public string? Late { get; set; }

    public string? Early { get; set; }

    public string? Chckin { get; set; }

    public string? Checkout { get; set; }

    public string? Hours { get; set; }

    public string? Gender { get; set; }

    public string? Typeofemployee { get; set; }

    public string? Pid { get; set; }

    public DateOnly? Date { get; set; }

    public decimal? Overtime { get; set; }

    public decimal? Totalworkinghours { get; set; }

    public string? Sltime { get; set; }
}
