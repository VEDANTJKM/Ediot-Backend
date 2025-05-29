using System;
using System.Collections.Generic;

namespace Dashboard.Models;

public partial class HibcPrimaryBarcodeTemp
{
    public int Id { get; set; }

    public int Mid { get; set; }

    public int UdiId { get; set; }

    public string? CharacterName { get; set; }

    public decimal? CharacetrValue { get; set; }

    public decimal? Reminder { get; set; }

    public string? PrimarySecondary { get; set; }
}
