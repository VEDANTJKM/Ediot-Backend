using System;
using System.Collections.Generic;

namespace Dashboard.Models;

public partial class Jobwork
{
    public string Gatepassno { get; set; } = null!;

    public int Id { get; set; }

    public int Pid { get; set; }

    public DateOnly? Gdate { get; set; }

    public string? Suppliername { get; set; }

    public string? Supplieraddress { get; set; }

    public string? Descriptionofgoods { get; set; }

    public decimal? Qty { get; set; }

    public decimal? Weight { get; set; }

    public decimal? Totalmaterialcost { get; set; }

    public string? Sswpart { get; set; }

    public string? Approxsswpartqty { get; set; }

    public string? Authorisedperson { get; set; }

    public string? Status { get; set; }

    public string? Receiverperson { get; set; }

    public DateOnly? Deliverydate { get; set; }

    public DateOnly? Returneddate { get; set; }

    public DateOnly? Cancelleddate { get; set; }

    public string? Reasonfordelete { get; set; }

    public decimal? Receivedsswpartqty { get; set; }

    public decimal? Receivedpartweight { get; set; }

    public string? Receiverremark { get; set; }
}
