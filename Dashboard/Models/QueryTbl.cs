using System;
using System.Collections.Generic;

namespace Dashboard.Models;

public partial class QueryTbl
{
    public int Id { get; set; }

    public int? PersonId { get; set; }

    public string? QueryTitle { get; set; }

    public string? Query { get; set; }

    public DateOnly? GeneratedDate { get; set; }

    public string? QueryStatus { get; set; }

    public DateOnly? CompletionDate { get; set; }
}
