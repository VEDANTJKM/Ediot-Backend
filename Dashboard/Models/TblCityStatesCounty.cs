using System;
using System.Collections.Generic;

namespace Dashboard.Models;

public partial class TblCityStatesCounty
{
    public int CityId { get; set; }

    public int StateId { get; set; }

    public int Countryid { get; set; }

    public string CityEnglish { get; set; } = null!;

    public string? CityArabic { get; set; }

    public string? CityOther { get; set; }

    public string? LandLine { get; set; }

    public string? Active1 { get; set; }

    public string? Active2 { get; set; }

    public long? CrupId { get; set; }

    public string? AssignedRoute { get; set; }

    public string? Shortcode { get; set; }

    public string? Zone { get; set; }

    public DateTime? UploadDate { get; set; }

    public string? Uploadby { get; set; }

    public DateTime? SyncDate { get; set; }

    public string? Syncby { get; set; }

    public int? SynId { get; set; }

    public bool? Deleted { get; set; }
}
