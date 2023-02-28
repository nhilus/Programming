using System;
using System.Collections.Generic;

namespace DAL.Entities;

public partial class ImportacaoFacturasTnt
{
    public int Id { get; set; }

    public byte FileType { get; set; }

    public string? MasterEdinumber { get; set; }

    public string? InvoiceNumber { get; set; }

    public int? InvoiceDate { get; set; }

    public string? InvoiceType { get; set; }

    public string? SettlementOption { get; set; }

    public decimal? TotalInvoiceCharge { get; set; }

    public int? TotalInvoiceTransactions { get; set; }

    public string? BilltoAccountNumber { get; set; }

    public string? BillToCountry { get; set; }

    public string? TntuseOnly { get; set; }

    public string? ConsolidatedAcctNo { get; set; }

    public string? CompanyCode { get; set; }

    public string? GroundTrackingPrefix { get; set; }

    public string? TrackingNumber { get; set; }

    public string? RebillIndicator { get; set; }

    public string? NonDuplicateTrackingIndicator { get; set; }

    public int? ShipDate { get; set; }

    public int? ServiceBase { get; set; }

    public int? ServicePackaging { get; set; }

    public string? GroundServiceCode { get; set; }

    public int? NumofDistributionAddresses { get; set; }

    public string? TrackingNumberMessageCode { get; set; }

    public string? Reference1 { get; set; }

    public string? Reference2 { get; set; }

    public string? Reference3 { get; set; }

    public string? StoreNumber { get; set; }

    public string? GroundPonumber { get; set; }

    public string? CustomerDepartmentNumber { get; set; }

    public string? CustomerInvoiceNumber { get; set; }

    public string? ReturnsMerchAuthorizationNumber { get; set; }

    public int? AutomationDeviceNumber { get; set; }

    public string? AutomationDeviceName { get; set; }

    public int? PayorType { get; set; }

    public decimal? NetCharge { get; set; }

    public string? CurrencyCode { get; set; }

    public string? Charge1 { get; set; }

    public decimal? FreightChargeAmt { get; set; }

    public string? Charge2 { get; set; }

    public decimal? VolumeDiscountAmt { get; set; }

    public string? Charge3 { get; set; }

    public decimal? EarnedDiscountAmt { get; set; }

    public string? Charge4 { get; set; }

    public decimal? AutomationDiscountAmt { get; set; }

    public string? Charge5 { get; set; }

    public decimal? PerfPricingDiscountAmt { get; set; }

    public string? Charge6 { get; set; }

    public decimal? FuelSurchargeAmt { get; set; }

    public string? Charge7 { get; set; }

    public decimal? ResidentialChargeAmt { get; set; }

    public string? Charge8 { get; set; }

    public decimal? DaschargeAmt { get; set; }

    public string? Charge9 { get; set; }

    public decimal? OnCallPickupAmt { get; set; }

    public string? Charge10 { get; set; }

    public decimal? DeclaredValueAmt { get; set; }

    public string? Charge11 { get; set; }

    public decimal? SignatureServiceAmt { get; set; }

    public string? Charge12 { get; set; }

    public decimal? SaturdayChargeAmt { get; set; }

    public string? Charge13 { get; set; }

    public decimal? AdditionalHandlingAmt { get; set; }

    public string? Charge14 { get; set; }

    public decimal? AddressCorrectionAmt { get; set; }

    public string? Charge15 { get; set; }

    public decimal? GstchargeAmt { get; set; }

    public string? Charge16 { get; set; }

    public decimal? OriginalDutyChargeAmt { get; set; }

    public string? Charge17 { get; set; }

    public decimal? DutyAdvancementFeeChargeAmt { get; set; }

    public string? Charge18 { get; set; }

    public decimal? OriginalVatamt { get; set; }

    public string? Charge19Misc { get; set; }

    public decimal? MiscCharge1Amt { get; set; }

    public string? Charge20Misc { get; set; }

    public decimal? MiscCharge2Amt { get; set; }

    public string? Charge21Misc { get; set; }

    public decimal? MiscCharge3Amt { get; set; }

    public decimal? ExchangeRate { get; set; }

    public string? OriginCurrencyCode { get; set; }

    public decimal? FuelSurchargeFactor { get; set; }

    public string? EuropeFirstSurchargeBand { get; set; }

    public string? CustLevelChargeCount { get; set; }

    public string? CallTagAccessCode { get; set; }

    public decimal? DeclaredValue { get; set; }

    public decimal? CustomsValue { get; set; }

    public string? CustomsDeclaredValueCurrency { get; set; }

    public string? CustomsEntryNumber { get; set; }

    public int? BundleMultiWeightIdno { get; set; }

    public string? RateScale { get; set; }

    public int? NumberofPieces { get; set; }

    public decimal? BilledWeight { get; set; }

    public decimal? OriginalWeight { get; set; }

    public decimal? GroundMultiWeightPkgWeight { get; set; }

    public string? WeightUnit { get; set; }

    public int? DimLength { get; set; }

    public int? DimWidth { get; set; }

    public int? DimHeight { get; set; }

    public string? DimUnit { get; set; }

    public int? DimDivisor { get; set; }

    public string? GroundMiscDescription1 { get; set; }

    public string? GroundMiscDescription2 { get; set; }

    public string? GroundMiscDescription3 { get; set; }

    public string? ShipperName { get; set; }

    public string? ShipperCompany { get; set; }

    public string? ShipperDept { get; set; }

    public string? ShipperAddressLine1 { get; set; }

    public string? ShipperAddressLine2 { get; set; }

    public string? ShipperCity { get; set; }

    public string? ShipperStateProvince { get; set; }

    public string? ShipperPostalCode { get; set; }

    public string? UsregionOriginZip { get; set; }

    public string? ShipperCountryCode { get; set; }

    public string? RegionCode { get; set; }

    public string? RecipientName { get; set; }

    public string? RecipientCompany { get; set; }

    public string? RecipientAddressLine1 { get; set; }

    public string? RecipientAddressLine2 { get; set; }

    public string? RecipientCity { get; set; }

    public string? RecipientStateProvince { get; set; }

    public string? RecipientPostalCode { get; set; }

    public string? RecipientCountryCode { get; set; }

    public string? DeliveryHandlingCode { get; set; }

    public int? DeliveryDate { get; set; }

    public int? DeliveryTime { get; set; }

    public string? DeliveryFinalDispositionCode { get; set; }

    public string? DeliveryExceptionCode { get; set; }

    public int? FirstAttemptDate { get; set; }

    public int? FirstAttemptTime { get; set; }

    public string? RecipientSignature { get; set; }

    public string? UsdelvyScheduleCode { get; set; }

    public int? CodcheckAmount { get; set; }

    public string? CodcrossReferenceTracking { get; set; }

    public string? PastDueIndicator { get; set; }

    public string? PastDueInvoiceNumber { get; set; }

    public string? ServiceLevelPercentage { get; set; }

    public decimal? RevenueThresholdAmount { get; set; }

    public string? OriginalRecipientAddressLine1 { get; set; }

    public string? OriginalRecipientAddressLine2 { get; set; }

    public string? OriginalRecipientCity { get; set; }

    public string? OriginalRecipientStateProvince { get; set; }

    public string? OriginalRecipientPostalCode { get; set; }

    public string? EuropeanUnionVatnumber { get; set; }

    public string? TntregisteredVatnumber { get; set; }

    public string? CrossReferenceTrackingNumber { get; set; }

    public string? InternationalGroundShipmentNumber { get; set; }

    public string? ControlCheckNumber { get; set; }

    public string? ResolutionCode { get; set; }

    public string? DenialRejectReasonCode { get; set; }

    public decimal? RequestedAdjustmentAmt { get; set; }

    public decimal? AmountDue { get; set; }

    public decimal? TotalAmountAdjusted { get; set; }

    public string? OriginalAdjustmentReasonCode { get; set; }

    public DateTime? DtIntrod { get; set; }

    public short? IdUtilIntrod { get; set; }

    public bool Processado { get; set; }

    public DateTime? DtProcessamento { get; set; }

    public string? XmlRubricas { get; set; }
}
