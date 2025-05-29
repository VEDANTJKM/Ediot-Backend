using System;
using System.Collections.Generic;

namespace Dashboard.Models;

public partial class Nonreturnablegatepass
{
    public string Gatepassno { get; set; } = null!;

    public int Id { get; set; }

    public int Gid { get; set; }

    public string? Descriptionofgoods { get; set; }

    public decimal? Qty { get; set; }

    public string? Remarks { get; set; }

    public string? Authorisedperson { get; set; }

    public string? Status { get; set; }

    public DateOnly? Deliverydate { get; set; }

    public DateOnly? Cancelleddate { get; set; }

    public string? Reasonfordelete { get; set; }

    public string? Supplieraddress { get; set; }
}
