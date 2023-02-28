using System;
using System.Collections.Generic;

namespace DAL.Entities;

public partial class Cobranca
{
    public int Id { get; set; }

    public DateTime DtIntrod { get; set; }

    public int IdUtilIntrod { get; set; }

    public DateTime? DtCobrar { get; set; }

    public int? IdCliente { get; set; }

    public int? IdCliMorada { get; set; }

    public string? ContactoAlt { get; set; }

    public string? MoradaAlt { get; set; }

    public int? IdCpostalAlt { get; set; }

    public string? TelfAlt { get; set; }

    public string? Awb { get; set; }

    public string? Factura { get; set; }

    public DateTime? DtFactura { get; set; }

    public int? IdTipoCobranca { get; set; }

    public decimal? Valcobrar { get; set; }

    public decimal? ValCobrado { get; set; }

    public int? IdTipoRecebimento { get; set; }

    public bool? Cheque { get; set; }

    /// <summary>
    /// indica se o estaf. ja tentou cobrar
    /// </summary>
    public bool? Tratado { get; set; }

    public bool? Cobrado { get; set; }

    public DateTime? DtCobrado { get; set; }

    public int? IdUtilCobrado { get; set; }

    public string? ObsCobrado { get; set; }

    public bool? Fechado { get; set; }

    public DateTime? DtFecho { get; set; }

    public int? IdUtilFecho { get; set; }

    public string? ObsFecho { get; set; }

    public bool Recebido { get; set; }

    public bool? FechadoVang { get; set; }

    public DateTime? DtFechadoVang { get; set; }

    public int? IdPlataforma { get; set; }

    public int? IdRota { get; set; }

    public int? IdPickup { get; set; }

    public int? IdManifesto { get; set; }

    public int? IdImportacaoManifesto { get; set; }

    public int? IdCabSaidasA { get; set; }

    public int? IdMaterialPedidos { get; set; }

    public int? IdCobrancaAdicional { get; set; }

    public bool? Billfedex { get; set; }

    public int? IdUtilBillFedEx { get; set; }

    public DateTime? DtBillFedEx { get; set; }

    public bool Anulado { get; set; }

    public DateTime? DtAnulado { get; set; }

    public int? IdUtilAnulado { get; set; }

    public int? IdUtilUltAct { get; set; }

    public DateTime? DtUltAct { get; set; }

    public int? IdDeptAreaDestino { get; set; }

    public bool? CobrancaLocal { get; set; }

    public int IdEntidade { get; set; }

    public int IdDistribuidor { get; set; }

    public bool EnvInterface { get; set; }

    public DateTime? DtEnvInterface { get; set; }

    public bool? Finalizar { get; set; }

    public bool Conferido { get; set; }

    public int? IdManifestoReembolso { get; set; }

    public string? ReembolsoAwb { get; set; }

    public DateTime? DtFinalizado { get; set; }

    public int? IdUtilFin { get; set; }

    public byte? IdMotivoEncerrar { get; set; }

    public bool Encerrado { get; set; }

    public DateTime? DtExportSap { get; set; }

    public DateTime? DtConfValidSap { get; set; }

    public bool? IsConfValidSap { get; set; }

    public string? Observacoes { get; set; }

    public int? IdMotivoNaoConferir { get; set; }

    public int? IdUtilNaoConferir { get; set; }

    public string? NrCheque { get; set; }

    public string? NrAvisoLiqSap { get; set; }

    public bool? ValidToSap { get; set; }

    public int? IdDeposito { get; set; }

    public DateTime? DtValidadeCheque { get; set; }

    public string? NrDebitoAgente { get; set; }

    public int? IdFornecedor { get; set; }

    public string? ObservacoesDebito { get; set; }
}
