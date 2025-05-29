using System;
using System.Collections.Generic;

namespace Dashboard.Models;

public partial class SswhiteGallery
{
    public int Mid { get; set; }

    public int ImageId { get; set; }

    public int Id { get; set; }

    public bool? Active { get; set; }

    public bool? Deleted { get; set; }

    public string? Title { get; set; }

    public string? ATitle { get; set; }

    public string? Type { get; set; }

    public string? Image { get; set; }

    public string? ImageName { get; set; }
}
