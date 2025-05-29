using System;
using System.Collections.Generic;

namespace Dashboard.Models;

public partial class ToolCategory
{
    public int Id { get; set; }

    public string? ToolCategory1 { get; set; }

    public string? ToolType { get; set; }

    public string? ToolTypeSearchWord { get; set; }

    public string? ToolTypeDescription { get; set; }

    public int? Mid { get; set; }

    public int? Pid { get; set; }

    public string? ToolTypeName { get; set; }

    public int? QtyInShopfloorMonday { get; set; }

    public string? Using { get; set; }
}
