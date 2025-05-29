using System;
using System.Collections.Generic;

namespace Dashboard.Models;

public partial class FinalInspectionUserList
{
    public int Id { get; set; }

    public int Mid { get; set; }

    public int UserId { get; set; }

    public string? UserName { get; set; }

    public string? Password { get; set; }
}
