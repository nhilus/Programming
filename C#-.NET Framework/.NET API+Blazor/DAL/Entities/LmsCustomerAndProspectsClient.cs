using System;
using System.Collections.Generic;

namespace DAL.Entities;

public partial class LmsCustomerAndProspectsClient
{
    public int Id { get; set; }

    public int ClientId { get; set; }

    public DateTime? GcomRecordCreationTimestamp { get; set; }

    public DateTime? GcomRecordUpdateTimestamp { get; set; }

    public string? AccountName1 { get; set; }

    public string? Vat { get; set; }

    public int? PrimaryActivityCode { get; set; }

    public string? PrimaryActivityDesc { get; set; }

    public string? CustomerLifeCycleStatus { get; set; }

    public string? Address1 { get; set; }

    public string? PostalCode { get; set; }

    public string? City { get; set; }

    public string? Province { get; set; }

    public string? Country { get; set; }

    public string? CompanyPhone { get; set; }

    public string? CompanyFax { get; set; }

    public string? CompanyEmail { get; set; }

    public string? ContactFirstName { get; set; }

    public string? ContactLastName { get; set; }

    public string? ContactSalutation { get; set; }

    public string? ContactRoleName { get; set; }

    public string? CurrentOppOwnerPin { get; set; }

    public string? CurrentOppOwnerSalesRole { get; set; }

    public string? CurrentOppOwnerName { get; set; }

    public string? CurrentOppOwnerSalesTerritory { get; set; }

    public decimal? TotalRev24m { get; set; }

    public decimal? TotalVol24m { get; set; }

    public decimal? TotalRev24mEma { get; set; }

    public decimal? TotalRev24mApac { get; set; }

    public decimal? TotalRev24mUscan { get; set; }

    public decimal? TotalRev24mLac { get; set; }

    public decimal? TotalVol24mEma { get; set; }

    public decimal? TotalVol24mApac { get; set; }

    public decimal? TotalVol24mUscan { get; set; }

    public decimal? TotalVol24mLac { get; set; }

    public decimal? TotalRev1m { get; set; }

    public decimal? TotalRev3m { get; set; }

    public decimal? TotalRev6m { get; set; }

    public decimal? TotalRev12m { get; set; }

    public decimal? TotalVol1m { get; set; }

    public decimal? TotalVol3m { get; set; }

    public decimal? TotalVol6m { get; set; }

    public decimal? TotalVol12m { get; set; }

    public decimal? TotalRevIp12m { get; set; }

    public decimal? TotalRevIpf12m { get; set; }

    public decimal? TotalRevIe12m { get; set; }

    public decimal? TotalRevIef12m { get; set; }

    public decimal? TotalVolIp12m { get; set; }

    public decimal? TotalVolIpf12m { get; set; }

    public decimal? TotalVolIe12m { get; set; }

    public decimal? TotalVolIef12m { get; set; }

    public DateTime DtUltAct { get; set; }

    public DateTime DtProcessamento { get; set; }
}
