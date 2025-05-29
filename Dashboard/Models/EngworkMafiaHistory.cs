using System;
using System.Collections.Generic;

namespace Dashboard.Models;

public partial class EngworkMafiaHistory
{
    public int Id { get; set; }

    public int Rid { get; set; }

    public int Mid { get; set; }

    public bool? SnAvailable { get; set; }

    public bool? FlAvailable { get; set; }

    public bool? MafiaMade { get; set; }

    public bool? MafiaReleased { get; set; }

    public DateTime? MafiaMadeDate { get; set; }

    public DateTime? MafiaReleasedDate { get; set; }

    public string? MafiaRemark { get; set; }

    public DateTime? MafiaCorrectionDate { get; set; }

    public DateTime? MafiaStatusCheckDate { get; set; }

    public int? MadeBy { get; set; }

    public bool? IsDeleted { get; set; }

    public bool? IsSaved { get; set; }

    public bool? IsSubmited { get; set; }

    public bool? IsSavedBy { get; set; }

    public DateTime? SaveTimestamp { get; set; }

    public DateTime? SubmitTimestamp { get; set; }
}
