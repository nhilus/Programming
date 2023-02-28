using System;
using System.Collections.Generic;

namespace DAL.Entities;

public partial class DlinkInvoice
{
    public int PkeyInvoice { get; set; }

    public int? BatchKey { get; set; }

    public DateTime? Received { get; set; }

    public string? InvoiceNum { get; set; }

    public string? MasterEdiacct { get; set; }

    public DateTime? InvoiceDate { get; set; }

    public string? BillToAcct { get; set; }

    public decimal? NetCharge { get; set; }

    public string? Currency { get; set; }

    public int? ShipmentCount { get; set; }

    public string? Gsacontract { get; set; }

    public string? InvoiceType { get; set; }

    public string? SettlementOption { get; set; }

    public string? CustomerStoreNum { get; set; }

    public decimal? AmtDue { get; set; }

    public decimal? AmtDueKey { get; set; }

    public string? Notes { get; set; }

    public string? Composition { get; set; }

    public string? Qualifier { get; set; }

    public int? BillSenderPieces { get; set; }

    public string? BillSenderWeightUnit { get; set; }

    public decimal? BillSenderWeight { get; set; }

    public decimal? BillSenderCharges { get; set; }

    public int? BillRecipientPieces { get; set; }

    public string? BillRecipientWeightUnit { get; set; }

    public decimal? BillRecipientWeight { get; set; }

    public decimal? BillRecipientCharges { get; set; }

    public int? BillThirdPieces { get; set; }

    public string? BillThirdWeightUnit { get; set; }

    public decimal? BillThirdWeight { get; set; }

    public decimal? BillThirdCharges { get; set; }

    public int? TotalPieces { get; set; }

    public string? TotalWeightUnit { get; set; }

    public decimal? TotalWeight { get; set; }

    public bool? Conferida { get; set; }

    public DateTime? DtConferida { get; set; }
}
