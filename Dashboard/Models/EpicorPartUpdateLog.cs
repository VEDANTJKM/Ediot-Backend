using System;
using System.Collections.Generic;

namespace Dashboard.Models;

public partial class EpicorPartUpdateLog
{
    public int Id { get; set; }

    public DateTime? UpdateOn { get; set; }

    public string? Type { get; set; }

    public int? LastRecordId { get; set; }
}
