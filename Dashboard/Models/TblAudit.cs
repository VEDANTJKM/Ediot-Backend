using System;
using System.Collections.Generic;

namespace Dashboard.Models;

public partial class TblAudit
{
    public long TenantId { get; set; }

    public long CrupId { get; set; }

    public int MySerial { get; set; }

    public int AuditNo { get; set; }

    public string? AuditType { get; set; }

    public string TableName { get; set; } = null!;

    public string? FieldName { get; set; }

    public string? OldValue { get; set; }

    public string? NewValue { get; set; }

    public DateTime? UpdateDate { get; set; }

    public string? UpdateUserName { get; set; }

    public DateTime? CreatedDate { get; set; }

    public string? CreatedUserName { get; set; }
}
