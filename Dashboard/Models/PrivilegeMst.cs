using System;
using System.Collections.Generic;

namespace Dashboard.Models;

public partial class PrivilegeMst
{
    public int TenentId { get; set; }

    public int PrivilegeId { get; set; }

    public string PrivilegeName { get; set; } = null!;

    public string PrivilegeDesc { get; set; } = null!;

    public string ActiveFlag { get; set; } = null!;

    public long CrupId { get; set; }

    public int ModuleId { get; set; }

    public string? PrivilegeName1 { get; set; }

    public string? PrivilegeName2 { get; set; }
}
