using System;
using System.Collections.Generic;

namespace Dashboard.Models;

public partial class VmsDataFromDashboard
{
    public int Id { get; set; }

    public int Mid { get; set; }

    public string? PersonId { get; set; }

    public DateTime? Datetime { get; set; }

    public DateOnly? Date { get; set; }

    public TimeOnly? Time { get; set; }

    public string? Status { get; set; }

    public string? Device { get; set; }

    public string? DeviceNo { get; set; }

    public string? PersonName { get; set; }

    public int? UserId { get; set; }
}
