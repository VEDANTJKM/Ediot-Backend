using System;
using System.Collections.Generic;

namespace Dashboard.Models;

public partial class HibcCodeGenerator
{
    public int Id { get; set; }

    public int Mid { get; set; }

    public int Pid { get; set; }

    public int UdiId { get; set; }

    public string? LabelerCode { get; set; }

    public string? BrandName { get; set; }

    public string? VersionOrModel { get; set; }

    public string? DeviceDescription { get; set; }

    public string? ProductCatalogueNumber { get; set; }

    public int? Uom { get; set; }

    public string? PrimaryCheckCharacter { get; set; }

    public string? PrimaryBarcodeData { get; set; }

    public string? TextUnderPrimaryBarCode { get; set; }

    public string? UpnUdiDeviceIdentifier { get; set; }

    public string? UpnUdiDeviceId { get; set; }

    public string? LotNumber { get; set; }

    public string? SecondaryCheckCharacter { get; set; }

    public string? SecondaryBarcodeData { get; set; }

    public string? TextUnderSecondaryBarCode { get; set; }

    public string? SecondaryBarcodeData2 { get; set; }

    public string? ConcentrateBarcode1 { get; set; }

    public string? ConcentrateBarcode2 { get; set; }

    public bool? Active { get; set; }

    public int? UserId { get; set; }

    public string? SecondaryBarcodeData1 { get; set; }

    public string? BarcodeImagename { get; set; }

    public string? DataMatrixImagename { get; set; }

    public string? QrcodeImagenameNew { get; set; }

    public DateOnly? ManufacturingDate { get; set; }

    public DateOnly? ExpirationDate { get; set; }

    public string? ExpirationDateFormate { get; set; }

    public string? ExpirationDateHour { get; set; }

    public int? IncQty { get; set; }

    public string? ConcentratedCheckCharacter { get; set; }

    public string? ConcentrateCheckCharacter1 { get; set; }

    public string? ConcentrateCheckCharacter2 { get; set; }
}
