using System;
using System.Collections.Generic;

namespace Dashboard.Models;

public partial class ProductDetail
{
    public int Mid { get; set; }

    public int Pid { get; set; }

    public int Id { get; set; }

    public string? ProductName { get; set; }

    public string? ProductInfoMain { get; set; }

    public string? ProductInfoInner { get; set; }

    public string? DescriptionProduct { get; set; }

    public string? ProductHeader { get; set; }
}
