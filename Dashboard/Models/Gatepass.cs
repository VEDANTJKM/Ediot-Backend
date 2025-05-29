using System;
using System.Collections.Generic;

namespace Dashboard.Models;

public partial class Gatepass
{
    public string Gpno { get; set; } = null!;

    public int Id { get; set; }

    public int Gid { get; set; }

    public DateTime? Gatedate { get; set; }

    public string? Suppliername { get; set; }

    public string? Descriptionofgoods { get; set; }

    public int? Qty { get; set; }

    public decimal? Price { get; set; }

    public string? Remarks { get; set; }

    public string? Authorizedperson { get; set; }

    public string? Status { get; set; }

    public string? Receiverperson { get; set; }

    public DateTime? Deliverydate { get; set; }

    public DateTime? Returneddate { get; set; }

    public DateTime? Cancelleddate { get; set; }

    public string? Reasonfordeletegatepass { get; set; }

    public int? ReceivedQty { get; set; }

    public string? Receiverremark { get; set; }

    public string? Supplieraddress { get; set; }

    public string? Gatepasstye { get; set; }

    public string? Weight { get; set; }

    public decimal? Totalmaterialcost { get; set; }

    public string? Sswpart { get; set; }

    public string? Approxsswpartqty { get; set; }

    public string? Authorisedperson { get; set; }

    public int? Receivedsswpartqty { get; set; }

    public decimal? Receivedpartweight { get; set; }

    public string? Supplierphone { get; set; }

    public string? Suppliergst { get; set; }

    public string? Supplieremail { get; set; }

    public int? Userid { get; set; }

    public string? Department { get; set; }

    public string? Historyallow { get; set; }

    public int? Returnst { get; set; }

    public int? PendingQty { get; set; }

    public string? Copytype { get; set; }

    public int? Copytypeconfirm { get; set; }

    public string? ForceCloseReason { get; set; }

    public string? Jobnum { get; set; }

    public string? PartialEntry { get; set; }

    public string? MaterialShape { get; set; }

    public string? MaterialGrade { get; set; }

    public int? Hsn { get; set; }

    public int? ApproxRecevingPartQty { get; set; }

    public string? ProcessesTypes { get; set; }

    public string? PackagingType { get; set; }

    public int? PackingQty { get; set; }

    public bool? Approved { get; set; }
}
