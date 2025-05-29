using System;
using System.Collections.Generic;

namespace Dashboard.Models;

public partial class FormulaMasterTbl
{
    public int Id { get; set; }

    public string? Formula { get; set; }

    public string? FormatedFormula { get; set; }

    public string? AddedBy { get; set; }

    public byte? IsActive { get; set; }
}
