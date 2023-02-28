using System;
using System.Collections.Generic;

namespace GCOM2Users.Models;

public partial class DlinkPackage
{
    public int PkeyPackages { get; set; }

    public int? ShipmentKey { get; set; }

    public string? InvoiceNum { get; set; }

    public string? TrackingId { get; set; }

    public int? Pieces { get; set; }

    public string? WeightUnit { get; set; }

    public decimal? Weight { get; set; }

    public decimal? OriginalWeight { get; set; }

    public int? Length { get; set; }

    public int? Width { get; set; }

    public int? Height { get; set; }

    public string? DimUnit { get; set; }

    public int? DimDivisor { get; set; }

    public decimal? DeclaredValue { get; set; }

    public decimal? CustomsValue { get; set; }

    public string? CustomsEntryNum { get; set; }

    public string? CustomsCurrency { get; set; }

    public string? GsadefaultWeight { get; set; }

    public decimal? RevenueThreshold { get; set; }

    public decimal? MultiweightWeight { get; set; }

    public string? Oversized { get; set; }

    public string? DangerousGoods { get; set; }

    public string? ClearancePort { get; set; }

    public string? AdditionalLineItems { get; set; }

    public int? StorageDays { get; set; }

    public int? CustodyDays { get; set; }

    public int? NumHours { get; set; }

    public string? DutyTaxWaiver { get; set; }
}
