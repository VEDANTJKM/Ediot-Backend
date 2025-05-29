using System;
using System.Collections.Generic;

namespace Dashboard.Models;

public partial class NotificationListDocument
{
    public int Id { get; set; }

    public int Mid { get; set; }

    public int Pid { get; set; }

    public string? DocumentAuthor { get; set; }

    public string? DocumentManager { get; set; }

    public string? EmpName { get; set; }

    public string? EmpId { get; set; }

    public string? ListType { get; set; }

    public string? Approval { get; set; }

    public DateTime? ApprovalDate { get; set; }

    public DateTime? NotificationDate { get; set; }
}
