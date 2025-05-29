using System;
using System.Collections.Generic;

namespace Dashboard.Models;

public partial class WhoIsInTheBuilding
{
    public int Id { get; set; }

    public int Pid { get; set; }

    public int PersonId { get; set; }

    public DateTime? Datetime { get; set; }

    public DateOnly? Date { get; set; }

    public string? Time { get; set; }

    public string? Status { get; set; }

    public string? Personname { get; set; }

    public int? Cid { get; set; }

    public string? PictureEmp { get; set; }
}
