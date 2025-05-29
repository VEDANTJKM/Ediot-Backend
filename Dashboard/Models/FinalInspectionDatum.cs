using System;
using System.Collections.Generic;

namespace Dashboard.Models;

public partial class FinalInspectionDatum
{
    public int Id { get; set; }

    public int Mid { get; set; }

    public string InspectionId { get; set; } = null!;

    public string? InwardTime { get; set; }

    public DateTime? InwardDate { get; set; }

    public string? JobNum { get; set; }

    public string? PartNum { get; set; }

    public string? Stage { get; set; }

    public string? EpiRev { get; set; }

    public string? ActRev { get; set; }

    public string? SampleQty { get; set; }

    public string? Mes { get; set; }

    public int? RejectQty { get; set; }

    public int? AcceptQty { get; set; }

    public int? ReworkQty { get; set; }

    public string? InspectionQty { get; set; }

    public int? SortingQty { get; set; }

    public int? DeviationQty { get; set; }

    public string? InspectionType { get; set; }

    public DateTime? CurrentDate { get; set; }

    public bool? Active { get; set; }

    public bool? Delete { get; set; }

    public bool? IsSubmiteed { get; set; }

    public bool? Statuschange { get; set; }

    public string? QualityStage { get; set; }

    public bool? Waitingforfinal { get; set; }

    public bool? Waitingforvisual { get; set; }

    public bool? Waitingforthread { get; set; }

    public bool? Waitingforhumidity { get; set; }

    public int? Qty { get; set; }

    public string? Note { get; set; }

    public bool? Waitingformrb { get; set; }

    public bool? Waitingforsorting { get; set; }

    public bool? Waitingforrework { get; set; }

    public bool? Inrework { get; set; }

    public bool? Completeandwaiting { get; set; }

    public bool? Indeviation { get; set; }

    public bool? Unitprice { get; set; }

    public bool? Completedandwaiting { get; set; }

    public bool? Readyforpacking { get; set; }

    public bool? Split { get; set; }

    public bool? Hold { get; set; }

    public bool? Movedfromquality { get; set; }

    public bool? Visualcompleted { get; set; }

    public bool? Threadcompleted { get; set; }

    public bool? Closerequest { get; set; }

    public bool? FinalRuning { get; set; }

    public string? Suppliername { get; set; }

    public DateTime? Mrbdate { get; set; }

    public string? CuurntCard { get; set; }

    public DateTime? CloseRequstDate { get; set; }

    public decimal? Rejectpersentage { get; set; }

    public decimal? Reworkpersentage { get; set; }

    public decimal? Deviationpersentage { get; set; }

    public string? Lotreject { get; set; }

    public decimal? TotalTimeinquality { get; set; }

    public string? InspectiontimeManpowerspendtime { get; set; }

    public string? TotalinspectiontimeManpowerspendtime { get; set; }

    public string? InspectiontimeQualitydivisionspendtimebypart { get; set; }

    public string? Totalinspectiontimequalitydivisionspendtimebypart { get; set; }

    public string? Mrbtakentime { get; set; }

    public decimal? Reworktime { get; set; }

    public decimal? Sortingtime { get; set; }

    public decimal? Deviationwaitingtime { get; set; }

    public DateTime? InReworkDate { get; set; }

    public DateTime? InSortingDate { get; set; }

    public DateTime? InDaviationTime { get; set; }

    public DateTime? MrbCreateDate { get; set; }
}
