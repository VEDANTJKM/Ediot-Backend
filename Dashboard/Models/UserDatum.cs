using System;
using System.Collections.Generic;

namespace Dashboard.Models;

public partial class UserDatum
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public string? Department { get; set; }

    public string? Username { get; set; }

    public string? Password { get; set; }

    public string? Role { get; set; }

    public string? Attachment { get; set; }

    public bool? IsDeleted { get; set; }
}
