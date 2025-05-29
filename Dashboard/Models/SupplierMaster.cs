using System;
using System.Collections.Generic;

namespace Dashboard.Models;

public partial class SupplierMaster
{
    public int Id { get; set; }

    public string? AutoSuppId { get; set; }

    public string? ManualSuppId { get; set; }

    public string? SuppName { get; set; }

    public string? ItemSupplied { get; set; }

    public string? AddOne { get; set; }

    public string? AddTwo { get; set; }

    public string? AddThree { get; set; }

    public string? City { get; set; }

    public string? State { get; set; }

    public string? PostalCode { get; set; }

    public string? Country { get; set; }

    public string? Phone { get; set; }

    public string? EmailId { get; set; }

    public string? GroupId { get; set; }

    public string? TaxId { get; set; }

    public string? PanNo { get; set; }

    public string? GstId { get; set; }

    public byte? IsDeleted { get; set; }

    public string? InsertTime { get; set; }

    public string? AddedBy { get; set; }
}
