using System;
using System.Collections.Generic;

namespace Dashboard.Models;

public partial class Signature
{
    public int Id { get; set; }

    public string FullName { get; set; } = null!;

    public string Initials { get; set; } = null!;

    public string SignatureText { get; set; } = null!;

    public string SignatureId { get; set; } = null!;

    public DateTime? CreatedDate { get; set; }

    public int? InitialId { get; set; }
}
