using System;
using System.Collections.Generic;

namespace Dashboard.Models;

public partial class InvoiceEntryMasterTbl
{
    public int Id { get; set; }

    public string? SlipNo { get; set; }

    public int? LineNo { get; set; }

    public DateOnly? InvoiceDate { get; set; }

    public DateOnly? InwardDate { get; set; }

    public DateOnly? PromiseDate { get; set; }

    public int? PoNo { get; set; }

    public int? PoLine { get; set; }

    public string? SupplierId { get; set; }

    public string? ConsumableNonConsumable { get; set; }

    public string? InvoiceNo { get; set; }

    public string? ChallanNo { get; set; }

    public string? RequistionNo { get; set; }

    public string? Department { get; set; }

    public string? ItemGroup { get; set; }

    public string? Category { get; set; }

    public string? ItemName { get; set; }

    public string? Hsn { get; set; }

    public string? Uom { get; set; }

    public double? PoQty { get; set; }

    public double? ReceivedQty { get; set; }

    public double? UnitPrice { get; set; }

    public double? GstPersentage { get; set; }

    public double? TransportationCharges { get; set; }

    public double? FrieghtCharges { get; set; }

    public double? PackagingCharges { get; set; }

    public double? AcceptedQty { get; set; }

    public double? UDAcceptedQty { get; set; }

    public int? Ltb { get; set; }

    public double? RejAtSuppliersEnd { get; set; }

    public double? Cd { get; set; }

    public double? Cost { get; set; }

    public double? GstAmount { get; set; }

    public double? TotalCost { get; set; }

    public double? QualityRating { get; set; }

    public int? DelayInDays { get; set; }

    public double? DeliveryRating { get; set; }

    public double? AverageRating { get; set; }

    public string? OverAllRating { get; set; }

    public bool IsDeleted { get; set; }

    public DateTime? InsertTime { get; set; }

    public string? AddedBy { get; set; }

    public int? FormulaId { get; set; }

    public string? Remark { get; set; }

    public string? ResonFordlt { get; set; }

    public bool? RequestForDelete { get; set; }
}
