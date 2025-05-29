using System;
using System.Collections.Generic;

namespace Dashboard.Models;

public partial class LateComingImgTable
{
    public int Id { get; set; }

    public string? Month { get; set; }

    public string? ImgPath { get; set; }
}
