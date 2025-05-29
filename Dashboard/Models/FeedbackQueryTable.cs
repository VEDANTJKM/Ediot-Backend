using System;
using System.Collections.Generic;

namespace Dashboard.Models;

public partial class FeedbackQueryTable
{
    public int Id { get; set; }

    public int Mid { get; set; }

    public string? QueryTitle { get; set; }

    public string? QueryReason { get; set; }

    public string? QueryApplicationName { get; set; }

    public DateTime? QueryGenerateDate { get; set; }

    public string? Active { get; set; }

    public string? Status { get; set; }

    public DateTime? QueryComplitionDate { get; set; }

    public string? RemarkOnCompletion { get; set; }

    public string? PersonId { get; set; }
}
