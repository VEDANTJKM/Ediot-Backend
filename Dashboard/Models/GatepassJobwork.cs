using System;
using System.Collections.Generic;

namespace Dashboard.Models;

public partial class GatepassJobwork
{
    public string Gpno { get; set; } = null!;

    public int Id { get; set; }

    public int Gid { get; set; }

    public int Pid { get; set; }

    public DateTime? Gatedate { get; set; }

    public string? Suppliername { get; set; }

    public string? Supplieraddress { get; set; }

    public string? Supplierphone { get; set; }

    public string? Suppliergst { get; set; }

    public string? Supplieremail { get; set; }

    public string? MaterialName { get; set; }

    public int? RawMaterialQty { get; set; }

    public string? Sswpart { get; set; }

    public decimal? Totalmaterialcost { get; set; }

    public string? Weight { get; set; }

    public string? Approxsswpartqty { get; set; }

    public string? Jobnum { get; set; }

    public string? Gatepasstype { get; set; }

    public bool? PartialCreated { get; set; }

    public string? Authorizedperson { get; set; }

    public string? Department { get; set; }

    public int? Userid { get; set; }

    public string? MaterialShape { get; set; }

    public string? MaterialGrade { get; set; }

    public int? Hsn { get; set; }

    public int? ApproxRecevingPartQty { get; set; }

    public string? ProcessesTypes { get; set; }

    public string? PackagingType { get; set; }

    public int? Qty { get; set; }
}
