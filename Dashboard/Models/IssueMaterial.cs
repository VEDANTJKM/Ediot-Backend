using System;
using System.Collections.Generic;

namespace Dashboard.Models;

public partial class IssueMaterial
{
    public string Reqno { get; set; } = null!;

    public int Id { get; set; }

    public int IssueId { get; set; }

    public int Receiptno { get; set; }

    public int Mid { get; set; }

    public string? ItemName { get; set; }

    public int? Onhandqty { get; set; }

    public int? Receivedqty { get; set; }

    public int? Totalqty { get; set; }
}
