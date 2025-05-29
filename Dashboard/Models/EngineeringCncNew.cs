using System;
using System.Collections.Generic;

namespace Dashboard.Models;

public partial class EngineeringCncNew
{
    public int Id { get; set; }

    public string PoNumber { get; set; } = null!;

    public string? PartNumber { get; set; }

    public int Pid { get; set; }

    public int? LineNumber { get; set; }

    public string? PreviouslyAvaOrNew { get; set; }

    public DateTime? PoDate { get; set; }

    public DateTime? PoReceivedDateEntry { get; set; }

    public string? Category { get; set; }

    public string? SubPart { get; set; }

    public int? RevisionNumber { get; set; }

    public string? SqrmCode { get; set; }

    public int? PoQty { get; set; }

    public string? PartMaximumDiaHeight { get; set; }

    public string? MaterialPartName { get; set; }

    public string? BarPlateDiameterDimensions { get; set; }

    public decimal? QuantityParent { get; set; }

    public string? Unit { get; set; }

    public string? SpecialToolDetail { get; set; }

    public string? PoDrawingRelatedRemarks { get; set; }

    public string? MaterialRelatedRemark { get; set; }

    public DateTime? DrawingAvailableDate { get; set; }

    public DateTime? DrawingVerifyDate { get; set; }

    public DateTime? PartEntryDate { get; set; }

    public DateTime? MaterialSuggestionEmailDate { get; set; }

    public DateTime? PtdDate { get; set; }

    public DateTime? OpSeqSheetCompleteDate { get; set; }

    public DateTime? MomCompleteDate { get; set; }

    public string? SnMadeOutSource { get; set; }

    public string? PtdFormRequired { get; set; }

    public string? PtdFormStatus { get; set; }

    public string? StageDrawingRequired { get; set; }

    public DateTime? StageDrawingAvailableDate { get; set; }

    public string? Op10 { get; set; }

    public string? Op20 { get; set; }

    public string? Op30 { get; set; }

    public string? Op40 { get; set; }

    public string? Op50 { get; set; }

    public string? Op60 { get; set; }

    public string? Op70 { get; set; }

    public string? Op80 { get; set; }

    public string? Op90 { get; set; }

    public string? Op100 { get; set; }

    public string? Op110 { get; set; }

    public string? Op120 { get; set; }

    public string? Op130 { get; set; }

    public string? Op140 { get; set; }

    public string? Op150 { get; set; }

    public string? Op160 { get; set; }

    public string? Op170 { get; set; }

    public string? Op180 { get; set; }

    public string? Op190 { get; set; }

    public string? Op200 { get; set; }

    public string? Op210 { get; set; }

    public string? Op220 { get; set; }

    public string? ProcessDetail { get; set; }

    public string? ProcessRemark { get; set; }

    public string? Template { get; set; }

    public string? SnAvaNota { get; set; }

    public string? NjAvaNota { get; set; }

    public string? MafiaMade { get; set; }

    public string? MafiaReleased { get; set; }

    public string? PirMafiaStatus { get; set; }

    public DateTime? CompDateMafiaStatusCheck { get; set; }

    public DateTime? MafiaMadeDate { get; set; }

    public DateTime? CorrectionDate { get; set; }

    public DateTime? ReleasedDate { get; set; }

    public string? MadeBy { get; set; }

    public string? MafiaRemark { get; set; }

    public string? KpiDrawingVerify { get; set; }

    public string? MomKpi { get; set; }

    public string? MaterialSuggestionKpi { get; set; }

    public string? WrongDrawingInPartLibrary { get; set; }

    public DateTime? PoEntryDate { get; set; }

    public DateTime? Partdate { get; set; }

    public int? PartFinalEntry { get; set; }

    public string? ToolCategory { get; set; }

    public string? ToolType { get; set; }

    public string? MafiaUpdateBy { get; set; }

    public DateTime? MomCreationDate { get; set; }

    public string? ToolTypeNew { get; set; }
}
