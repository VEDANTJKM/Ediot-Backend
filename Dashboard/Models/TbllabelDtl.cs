using System;
using System.Collections.Generic;

namespace Dashboard.Models;

public partial class TbllabelDtl
{
    public int Id { get; set; }

    public int? LocationId { get; set; }

    public string? LabelMstId { get; set; }

    public string? FieldName { get; set; }

    public string? LabelId { get; set; }

    public string? LabelName { get; set; }

    public int? LangId { get; set; }

    public int? Countryid { get; set; }

    public string? Langdisp { get; set; }

    public bool? Active { get; set; }

    public long? CrupId { get; set; }
}
