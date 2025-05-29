using System;
using System.Collections.Generic;

namespace Dashboard.Models;

public partial class EpoCreation
{
    public int Id { get; set; }

    public int Eid { get; set; }

    public int Pid { get; set; }

    public int Gid { get; set; }

    public int Lid { get; set; }

    public string Epoid { get; set; } = null!;

    public string? EmployeeVendor { get; set; }

    public int? EmployeeId { get; set; }

    public int? Userid { get; set; }

    public string? Vendor { get; set; }

    public string? VendorId { get; set; }

    public string? Street1 { get; set; }

    public string? Street2 { get; set; }

    public string? Country { get; set; }

    public string? State { get; set; }

    public string? City { get; set; }

    public string? Zip { get; set; }

    public string? Phone { get; set; }

    public string? Fax { get; set; }

    public string? GstNo { get; set; }

    public string? Email { get; set; }

    public string? Purposeofpurchase { get; set; }

    public string? EpoType { get; set; }

    public string? ReceiptMethod { get; set; }

    public string? EpoPurchaseStatus { get; set; }

    public string? PaymentType { get; set; }

    public string? PaymentGivenBy { get; set; }

    public string? ProductDescription { get; set; }

    public string? ProductGroup { get; set; }

    public decimal? Qty { get; set; }

    public decimal? UnitPrice { get; set; }

    public string? Uom { get; set; }

    public string? UomOther { get; set; }

    public string? Department { get; set; }

    public string? AccountNo { get; set; }

    public decimal? Tax { get; set; }

    public decimal? Discount { get; set; }

    public decimal? CostOfUnitPriceAndQty { get; set; }

    public decimal? ExtendedCost { get; set; }

    public decimal? TaxWithDiscount { get; set; }

    public decimal? TaxDiscountGst { get; set; }

    public string? WithinGujarat { get; set; }

    public decimal? Gst { get; set; }

    public decimal? Cgst { get; set; }

    public decimal? Sgst { get; set; }

    public decimal? Igst { get; set; }

    public string? PurchaseType { get; set; }

    public string? AttachmentFileName { get; set; }

    public DateTime? AttachmentDate { get; set; }

    public int? AttachedByEmployee { get; set; }

    public string? PurchaseNotes { get; set; }

    public string? InternalNotes { get; set; }

    public decimal? ShippingCharges { get; set; }

    public decimal? SubTotal { get; set; }

    public decimal? GrandTotal { get; set; }

    public string? EmployeeName { get; set; }

    public DateTime? DateOfPaymentCheckRequestOrCashAdvance { get; set; }

    public string? DaysOfPaymentPayWhenBilled { get; set; }

    public string? GujaratOrOutside { get; set; }

    public DateTime? CreateDate { get; set; }

    public string? CreatedBy { get; set; }

    public string? SelfApproval { get; set; }

    public string? ManagerApproval { get; set; }

    public string? MpcApproval { get; set; }

    public string? MpcHigherApproval { get; set; }

    public DateTime? SelfDate { get; set; }

    public DateTime? ManagerApprovalDate { get; set; }

    public DateTime? MpcApprovalDate { get; set; }

    public DateTime? MpcHigherApprovalDate { get; set; }

    public string? QtyStatus { get; set; }

    public int? UserId { get; set; }

    public DateTime? RevisedDate { get; set; }

    public string? ApprovedBy { get; set; }

    public string? Street3 { get; set; }

    public string? CurrencyType { get; set; }

    public string? WithoutAttachment { get; set; }
}
