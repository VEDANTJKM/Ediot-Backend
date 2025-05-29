using System;
using System.Collections.Generic;

namespace Dashboard.Models;

public partial class BackupLog
{
    public int Id { get; set; }

    public int Pid { get; set; }

    public string? Filename { get; set; }

    public DateTime? CreatedDate { get; set; }
}
