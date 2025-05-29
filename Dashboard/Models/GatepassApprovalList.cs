using System;
using System.Collections.Generic;

namespace Dashboard.Models;

public partial class GatepassApprovalList
{
    public int Id { get; set; }

    public int Mid { get; set; }

    public string? Departmentname { get; set; }

    public string? DepartmentsupervisorManager { get; set; }

    public string? Departmentsupervisorname { get; set; }

    public string? ColorCode { get; set; }

    public string? PersonId { get; set; }

    public string? DepartmentsupervisorDeputyManager { get; set; }
}
