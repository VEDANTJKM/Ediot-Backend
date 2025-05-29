using System;
using System.Collections.Generic;

namespace Dashboard.Models;

public partial class DeptSoftwareSubscription
{
    public int Id { get; set; }

    public int Mid { get; set; }

    public int Pid { get; set; }

    public string? SoftwareName { get; set; }

    public string? Version { get; set; }

    public string? SoftwareType { get; set; }

    public string? Purpose { get; set; }

    public string? VendorContactDetails { get; set; }

    public int? NoOfLicence { get; set; }

    public string? PrimaryDepartment { get; set; }

    public DateOnly? SubscriptionStartDate { get; set; }

    public string? SubsccriptionTimePeriod { get; set; }

    public DateOnly? NextRenewalDate { get; set; }

    public int? Price { get; set; }

    public string? PaymentBy { get; set; }

    public string? UploadBy { get; set; }

    public DateOnly? UploadDate { get; set; }
}
