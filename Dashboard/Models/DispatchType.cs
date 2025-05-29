using System;
using System.Collections.Generic;

namespace Dashboard.Models;

public partial class DispatchType
{
    public int Id { get; set; }

    public string? Type { get; set; }

    public string? SnplantName { get; set; }

    public string? SnplantAddressLine1 { get; set; }

    public string? SnplantAddressLine2 { get; set; }

    public string? SnplantAddressLine3 { get; set; }

    public string? Dist { get; set; }

    public string? State { get; set; }

    public string? Country { get; set; }

    public string? Phone { get; set; }

    public string? ConsigneeAddressName { get; set; }

    public string? ConsigneeAddressLine1 { get; set; }

    public string? ConsigneeAddressLine2 { get; set; }

    public string? ConsigneeAddressLine3 { get; set; }

    public string? ConsigneeDist { get; set; }

    public string? ConsigneeState { get; set; }

    public string? ConsigneeCountry { get; set; }

    public string? ConsigneeFacility { get; set; }

    public int? ConsigneePhone { get; set; }

    public string? BuyerAddressName { get; set; }

    public string? BuyerAddressLine1 { get; set; }

    public string? BuyerAddressLine2 { get; set; }

    public string? BuyerAddressLine3 { get; set; }

    public string? BuyerDist { get; set; }

    public string? BuyerState { get; set; }

    public string? BuyerFacility { get; set; }

    public string? BuyerCountry { get; set; }

    public int? BuyerPhone { get; set; }

    public string? FinalDestination { get; set; }

    public string? PortOfDischarge { get; set; }

    public string? KindAttention { get; set; }

    public string? PortOfLoading { get; set; }

    public string? DestinationCountry { get; set; }

    public string? CountryOfOrigin { get; set; }

    public string? PaymentTerms { get; set; }

    public string? VesselFlightNo { get; set; }

    public string? TermsOfDelivery { get; set; }

    public string? Iecno { get; set; }

    public string? Gstin { get; set; }

    public string? Fei { get; set; }

    public string? FdafacilityRegn { get; set; }

    public string? Cin { get; set; }

    public string? Signature { get; set; }

    public string? OtherReference1 { get; set; }

    public string? OtherReference2 { get; set; }

    public string? TypeCode { get; set; }

    public bool? IsActive { get; set; }

    public string? Hscode { get; set; }

    public int? Ritc { get; set; }

    public string? Description { get; set; }

    public bool? ActiveLogs { get; set; }
}
