using System;
using System.Collections.Generic;

namespace Dashboard.Models;

public partial class AdvanceLicencesOperationTbl
{
    public int Id { get; set; }

    public int? RId { get; set; }

    public string? RmOperation { get; set; }

    public decimal? QtyRejectedInNumber { get; set; }

    public decimal? RejectedQtyInKg { get; set; }

    public decimal? OkQtyPieace { get; set; }

    public decimal? WasteScrap { get; set; }

    public string? UploadedName { get; set; }

    public DateTime? UploadedDate { get; set; }

    public decimal? FgOkQtyKg { get; set; }

    public decimal? FgOkQtyPc { get; set; }

    public decimal? IssuedQtyKg { get; set; }

    public decimal? ReturnQtyInch { get; set; }

    public decimal? ReturnQtyKg { get; set; }

    public string? ReturnRemark { get; set; }

    public string? Status { get; set; }
}
