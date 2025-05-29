using System;
using System.Collections.Generic;

namespace Dashboard.Models;

public partial class SupplierNewDatum
{
    public int Id { get; set; }

    public int Mid { get; set; }

    public string SupplierId { get; set; } = null!;

    public string? SuppName { get; set; }

    public string? SuppAdd1 { get; set; }

    public string? SuppAdd2 { get; set; }

    public string? SuppAdd3 { get; set; }

    public string? City { get; set; }

    public string? State { get; set; }

    public string? PostalCode { get; set; }

    public string? Country { get; set; }

    public string? Phone { get; set; }

    public string? EmailId { get; set; }

    public string? Gstin { get; set; }

    public string? RegisterType { get; set; }
}
