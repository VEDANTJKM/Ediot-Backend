using System;
using System.Collections.Generic;

namespace Dashboard.Models;

public partial class Icrdtemp
{
    public int Id { get; set; }

    public int? Name { get; set; }

    public string? Image { get; set; }

    public string? NameNew { get; set; }

    public string? ImageNew { get; set; }

    public string? Add1 { get; set; }

    public string? Add2 { get; set; }

    public string? Bloodgroup { get; set; }

    public string? Signature { get; set; }

    public string? Dob { get; set; }

    public string? Doj { get; set; }

    public bool? BackRequired { get; set; }
}
