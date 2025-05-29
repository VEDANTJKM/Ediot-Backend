using System;
using System.Collections.Generic;

namespace Dashboard.Models;

public partial class UserMstForShoulder
{
    public int Id { get; set; }

    public int Mid { get; set; }

    public int Pid { get; set; }

    public string? Username { get; set; }

    public string? Password { get; set; }

    public string? ConfirmPassword { get; set; }

    public string? Role { get; set; }

    public string? Organization { get; set; }

    public string? Email { get; set; }

    public string? FirstName { get; set; }

    public string? LastName { get; set; }

    public string? MobileNumber { get; set; }

    public bool? ApprovedByAdmin { get; set; }

    public string? Status { get; set; }

    public bool? AdminRights { get; set; }
}
