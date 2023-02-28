using System;
using System.Collections.Generic;

namespace GCOM2Users.Models;

public partial class ManifestoExpedicao
{
    public int IdMaster { get; set; }

    public string Awb { get; set; } = null!;

    public byte IdEntidade { get; set; }

    public bool IsDirty { get; set; }

    public DateTime? RouteDate { get; set; }

    public byte? IdAviao { get; set; }

    public string? VisaRoute { get; set; }

    public string? FlightDestination { get; set; }

    public short? BatchNumber { get; set; }

    public short? IdEstacaoOrigem { get; set; }

    public string? EstacaoOrigem { get; set; }

    public short? IdPaisOrigem { get; set; }

    public string? CodPaisOrigem { get; set; }

    public short? IdEstacaoDestino { get; set; }

    public string? EstacaoDestino { get; set; }

    public string? ServiceType { get; set; }

    public string? ProductType { get; set; }

    public string? HandlingCode { get; set; }

    public string? HandlingCode2 { get; set; }

    public bool? DangerousGoodsFlag { get; set; }

    public bool? CargoAircraftOnly { get; set; }

    public bool? ExtractedForTransfer { get; set; }

    public string? HarmonizedCode { get; set; }

    public short? IdPaisManufactura { get; set; }

    public bool? ExportLicense { get; set; }

    public bool? ThermalAwb { get; set; }

    public bool? Cflag { get; set; }

    public byte? IdTipoCflag { get; set; }

    public bool? NonComercialFlag { get; set; }

    public bool? IsDutyDue { get; set; }

    public string? AwbCategoryCustoms { get; set; }

    public string? Moeda { get; set; }

    public byte? IdMoeda { get; set; }

    public decimal? ValorCarriage { get; set; }

    public decimal? ValorAlfandega { get; set; }

    public byte? IdReceivedAt { get; set; }

    public bool? ParaExpToGrasp { get; set; }

    public DateTime? DtParaExpToGrasp { get; set; }

    public short? IdUtilParaExpToGrasp { get; set; }

    public bool ValidToGrasp { get; set; }

    public DateTime? DtValidToGrasp { get; set; }

    public short? IdUtilValidToGrasp { get; set; }

    public bool ExpToGrasp { get; set; }

    public DateTime? DtExpToGrasp { get; set; }

    public short? IdUtilExpToGrasp { get; set; }

    public DateTime? DtUpdatedFromCosmos { get; set; }

    public DateTime? DtValidatedInCosmos { get; set; }

    public short IdUtilUltAct { get; set; }

    public DateTime DtUltAct { get; set; }

    public int? IdContaClienteFilho { get; set; }

    public DateTime? TransactionDateTime { get; set; }

    public string? GoodsClassCd { get; set; }

    public bool? DespachoExport { get; set; }

    public bool? TemDocumentacaoValida { get; set; }

    public int? IdUtilDocVal { get; set; }

    public DateTime? DtDocVal { get; set; }
}
