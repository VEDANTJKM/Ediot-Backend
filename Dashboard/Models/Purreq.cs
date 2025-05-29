using System;
using System.Collections.Generic;

namespace Dashboard.Models;

public partial class Purreq
{
    public string ReqNo { get; set; } = null!;

    public int Id { get; set; }

    public int Pid { get; set; }

    public string? Nameofinitiator { get; set; }

    public string? Department { get; set; }

    public string? Itemname { get; set; }

    public string? Purpose { get; set; }

    public string? Itemtype { get; set; }

    public string? Uom { get; set; }

    public int? Itemqty { get; set; }

    public int? Totalkg { get; set; }

    public decimal? PeruomPrice { get; set; }

    public decimal? Extracharge { get; set; }

    public string? SuggestedSupplier { get; set; }

    public string? RemarkOnItem { get; set; }

    public DateTime? AskforquotationDate { get; set; }

    public string? SupplierName { get; set; }

    public string? Epo { get; set; }

    public DateTime? EpoDate { get; set; }

    public string? EpoStatus { get; set; }

    public DateTime? ReceivedDate { get; set; }

    public DateTime? BillReceivedDate { get; set; }

    public string? RemarkOnReceivedItem { get; set; }

    public string? PurchaserRemark { get; set; }

    public string? CheckPoint { get; set; }

    public DateTime? ItemIssueDateAgainstReqNo { get; set; }

    public string? ItemIssueToPerson { get; set; }

    public string? Status { get; set; }

    public int? Cid { get; set; }

    public DateTime? ReqDate { get; set; }

    public decimal? ReceivedQty { get; set; }

    public string? Approval { get; set; }

    public string? Remarkonitem { get; set; }

    public DateTime? DueDate { get; set; }

    public bool? Askforquotation { get; set; }

    public string? Billno { get; set; }

    public int? PendingQty { get; set; }

    public string? ChallanNo { get; set; }

    public string? InvoiceNo { get; set; }

    public int? Qtymanage { get; set; }

    public string? InvoiceNo2 { get; set; }

    public string? InvoiceNo3 { get; set; }

    public string? InvoiceNo4 { get; set; }

    public string? InvoiceNo5 { get; set; }

    public string? ChallanNo2 { get; set; }

    public string? ChallanNo3 { get; set; }

    public string? ChallanNo4 { get; set; }

    public string? ChallanNo5 { get; set; }

    public string? Epo2 { get; set; }

    public string? Epo3 { get; set; }

    public string? Epo4 { get; set; }

    public string? Epo5 { get; set; }

    public string? Payslipnumber { get; set; }

    public string? QuotationType { get; set; }

    public int? EpoLineno { get; set; }

    public decimal? ItemqtyNew { get; set; }

    public string? IssueStatus { get; set; }

    public string? Attachment { get; set; }

    public string? FilterAllow { get; set; }

    public string? Reasonforedit { get; set; }

    public decimal? IssueItemQty { get; set; }

    public string? RemarkInQuery { get; set; }

    public bool? QueryInReq { get; set; }

    public bool? QueryResolve { get; set; }

    public string? QueryResolveRemark { get; set; }

    public DateTime? ReqInQueryDate { get; set; }

    public DateTime? QueryResolveDate { get; set; }

    public string? EpoAttachment { get; set; }

    public bool? PerfomaWaiting { get; set; }

    public DateTime? PerformaWaitingDate { get; set; }

    public DateTime? IntransitDate { get; set; }

    public string? VoidRemark { get; set; }

    public DateTime? VoidDate { get; set; }
}
