using System;
using System.Collections.Generic;

namespace DAL.Entities;

public partial class DlinkShipment
{
    public int PkeyShipment { get; set; }

    public int? InvoiceKey { get; set; }

    public int? BatchKey { get; set; }

    public DateTime? Received { get; set; }

    public string? TrackingId { get; set; }

    public string? InvoiceNum { get; set; }

    public string? GroundTrackingId { get; set; }

    public string? BillToAcct { get; set; }

    public DateTime? ShipDate { get; set; }

    public string? BillingSource { get; set; }

    public string? CommerceType { get; set; }

    public int? ServiceBase { get; set; }

    public int? ServicePackaging { get; set; }

    public int? PaymentPayor { get; set; }

    public string? Reference { get; set; }

    public decimal? NetCharge { get; set; }

    public string? Currency { get; set; }

    public string? Rebill { get; set; }

    public string? Prerated { get; set; }

    public string? RateScale { get; set; }

    public int? Region { get; set; }

    public int? RegionOriginZip { get; set; }

    public int? PsbundleNum { get; set; }

    public int? DistributionAddresses { get; set; }

    public string? FormId { get; set; }

    public decimal? Codamount { get; set; }

    public string? CodcrossRefTrackingId { get; set; }

    public string? ConsolidatedAccount { get; set; }

    public int? CompanyCode { get; set; }

    public string? GroundServiceCode { get; set; }

    public string? CustomerPo { get; set; }

    public string? CustomerDept { get; set; }

    public string? CustomerInvoiceNum { get; set; }

    public DateTime? CommitDate { get; set; }

    public string? Exception { get; set; }

    public string? ExceptionProcess { get; set; }

    public string? Cod { get; set; }

    public decimal? AmtDue { get; set; }

    public decimal? AmtDueKey { get; set; }

    public string? HasTrack { get; set; }

    public string? HasPod { get; set; }

    public string? CostAllocation { get; set; }

    public string? Notes { get; set; }

    public string? PastDue { get; set; }

    public string? PastDueInvoiceNum { get; set; }

    public int? AutomationDeviceNum { get; set; }

    public string? AutomationDeviceName { get; set; }

    public string? ShipperDept { get; set; }

    public string? Crreference { get; set; }

    public string? Sireference { get; set; }

    public string? NonDuplicateIndicator { get; set; }

    public int? MultiweightIdOrPerformancePricingId { get; set; }

    public string? ReturnedMerchandiseAuthorizationNum { get; set; }

    public DateTime? InvoiceDate { get; set; }

    public bool? Conferida { get; set; }

    public DateTime? DtConferida { get; set; }

    public int? IdUtilConferida { get; set; }
}
