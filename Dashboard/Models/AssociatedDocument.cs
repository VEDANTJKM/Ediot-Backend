using System;
using System.Collections.Generic;

namespace Dashboard.Models;

public partial class AssociatedDocument
{
    public int Id { get; set; }

    public int Mid { get; set; }

    public int Pid { get; set; }

    public int? DocumentId { get; set; }

    public int? Rev { get; set; }

    public string? Title { get; set; }

    public string? DocumentIdTitle { get; set; }
}
