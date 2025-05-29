using System;
using System.Collections.Generic;

namespace Dashboard.Models;

public partial class GatepassReturnablenew
{
    public string Gpno { get; set; } = null!;

    public int Id { get; set; }

    public int Gid { get; set; }

    public int Pid { get; set; }

    public DateTime? Gatedate { get; set; }

    public decimal? ItemQty { get; set; }

    public decimal? RemainingQty { get; set; }

    public decimal? ReceivedQty { get; set; }

    public decimal? TransactionQty { get; set; }

    public DateTime? ReceivedDate { get; set; }

    public string? ReceivedPerson { get; set; }

    public string? ItemName { get; set; }

    public int? MailSend { get; set; }
}
