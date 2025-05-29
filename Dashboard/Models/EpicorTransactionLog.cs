using System;
using System.Collections.Generic;

namespace Dashboard.Models;

public partial class EpicorTransactionLog
{
    public int Id { get; set; }

    public string? TransNum { get; set; }

    public string? PartNum { get; set; }

    public string? WareHouse { get; set; }

    public string? BinNum { get; set; }

    public string? TransType { get; set; }

    public DateOnly? TransDate { get; set; }

    public decimal? TransQty { get; set; }

    public string? Uom { get; set; }

    public string? EntryPerson { get; set; }

    public string? TransReference { get; set; }

    public string? PartDescription { get; set; }

    public string? PackSlip { get; set; }

    public string? InvoiceNum { get; set; }

    public string? LotNum { get; set; }

    public DateOnly? SysDate { get; set; }

    public int? SysTime { get; set; }

    public string? Company { get; set; }

    public string? ClassId { get; set; }
}
