using System;
using System.Collections.Generic;

namespace Dashboard.Models;

public partial class ProductImage
{
    public int Mid { get; set; }

    public int Id { get; set; }

    public int Pid { get; set; }

    public string? ProductName { get; set; }

    public string? ProductImage1 { get; set; }
}
