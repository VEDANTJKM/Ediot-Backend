using System;
using System.Collections.Generic;

namespace Dashboard.Models;

public partial class UserRolesWithOccupation
{
    public int Id { get; set; }

    public int Mid { get; set; }

    public int Pid { get; set; }

    public string ShoulderId { get; set; } = null!;

    public string? OccupationName { get; set; }

    public string? MenuName { get; set; }

    public bool? Active { get; set; }

    public DateTime? UploadDate { get; set; }

    public string? MenuIcon { get; set; }

    public string? MenuRole { get; set; }

    public bool? RoleActive { get; set; }

    public string? MenuLink { get; set; }
}
