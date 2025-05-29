using System;
using System.Collections.Generic;

namespace Dashboard.Models;

public partial class LoginTbl
{
    public int Id { get; set; }

    public string? UserId { get; set; }

    public string? Name { get; set; }

    public string? Username { get; set; }

    public string? Profile { get; set; }

    public string? Department { get; set; }

    public string? Role { get; set; }

    public string? Email { get; set; }

    public string? Password { get; set; }

    public int? IsDeleted { get; set; }
}
