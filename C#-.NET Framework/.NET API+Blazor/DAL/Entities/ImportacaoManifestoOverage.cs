using System;
using System.Collections.Generic;

namespace DAL.Entities;

public partial class ImportacaoManifestoOverage
{
    public int Id { get; set; }

    public string? RecordType { get; set; }

    public string? MasterNumber { get; set; }

    public string? MasterFormId { get; set; }

    public string AwbNumber { get; set; } = null!;

    public string? AwbFormId { get; set; }

    public string? EstacaoOrigem { get; set; }

    public string? EstacaoDestino { get; set; }

    public int? IdEstacaoDestino { get; set; }

    public string? PaisOrigem { get; set; }

    public int? IdPaisOrigem { get; set; }

    public string? PaisExportacao { get; set; }

    public DateTime? DataOrigem { get; set; }

    public string? RemTelefone { get; set; }

    public string? RemEmpresa { get; set; }

    public string? RemResponsavel { get; set; }

    public string? RemMorada { get; set; }

    public string? RemLocalidade { get; set; }

    public string? RemEstado { get; set; }

    public string? RemPais { get; set; }

    public int? RemIdPais { get; set; }

    public string? RemCpostal { get; set; }

    public int? IdCliente { get; set; }

    public string? DesTelefone { get; set; }

    public string? DesEmpresa { get; set; }

    public string? DesResponsavel { get; set; }

    public string? DesMorada { get; set; }

    public string? DesLocalidade { get; set; }

    public string? DesEstado { get; set; }

    public string? DesPais { get; set; }

    public string? DesCpostal { get; set; }

    public string? ServiceType { get; set; }

    public string? TipoProduto { get; set; }

    public int? IdTipoProduto { get; set; }

    public string? DangerousGoods { get; set; }

    public string? BillTc { get; set; }

    public int? NumeroPacotes { get; set; }

    public decimal? PesoTotal { get; set; }

    public string? Moeda { get; set; }

    public decimal? ValorTotal { get; set; }

    public string? Descricao { get; set; }

    public bool? DutyDue { get; set; }

    public bool? Cflag { get; set; }

    public decimal? ValorCarriage { get; set; }

    public string? BillDt { get; set; }

    public string? Vatnumber { get; set; }

    public string? DataDownload { get; set; }

    public string? Extracted { get; set; }

    public string? AwbCategoryCustoms { get; set; }

    public string? StatusGraspCsp { get; set; }

    public string? Status { get; set; }

    public bool? TxBack { get; set; }

    public string? DateUpdated { get; set; }

    public string? VisaRoute { get; set; }

    public DateTime? ArrivalDate { get; set; }

    public string? FlightDestination { get; set; }

    public bool? Dirty { get; set; }

    public DateTime? DataVerifSf { get; set; }

    public bool? Enviado { get; set; }

    public int? IdClienteFact { get; set; }

    public int? IdTarifa { get; set; }

    public decimal? PercDesconto { get; set; }

    public decimal? PesoReal { get; set; }

    public decimal? CustoFedEx { get; set; }

    public DateTime? DtValor { get; set; }

    public int? IdUtilValor { get; set; }

    public bool? ValorBaseManual { get; set; }

    public decimal? TransportCharges { get; set; }

    public int? IdMoeda { get; set; }

    public decimal? Cambio { get; set; }

    public decimal? TaxaIvavalorBase { get; set; }

    public bool? Ipf { get; set; }

    public bool? VendaDinheiro { get; set; }

    public decimal? ValorVendaDinheiro { get; set; }

    public string? ObsVendaDinheiro { get; set; }

    public bool? FacturacaoIndividual { get; set; }

    public bool ValidToFact { get; set; }

    public DateTime? DtValidToFact { get; set; }

    public int? IdutilValidToFact { get; set; }

    public bool? ExpToFact { get; set; }

    public DateTime? DtExpToFact { get; set; }

    public int? IdutilExpToFact { get; set; }

    public bool? Fact { get; set; }

    public DateTime? DtFact { get; set; }

    public string? Observacoes { get; set; }

    public string? ObservacoesDaf { get; set; }

    public int? IdUtilFecho { get; set; }

    public DateTime? DtFecho { get; set; }

    public string? NumFacturaFedEx { get; set; }

    public bool? ReclamarFedEx { get; set; }

    public decimal? ValorReclamado { get; set; }

    public int? IdUtilConferencia { get; set; }

    public DateTime? DtConferencia { get; set; }

    public string? AwbRts { get; set; }

    public int? IdUtilRts { get; set; }

    public DateTime? DtRts { get; set; }

    public int IdEntidade { get; set; }

    public int? IdAssinatura { get; set; }

    public int? IdUtilUltAct { get; set; }

    public DateTime? DtUltAct { get; set; }

    public int IdDistribuidor { get; set; }

    public int? Processo { get; set; }

    public string? BillTcaccount { get; set; }

    public DateTime? DtEntregue { get; set; }

    public string? SignEntregue { get; set; }

    public DateTime? DtRecolhido { get; set; }

    public string? SignRecolhido { get; set; }

    public DateTime? DtIntrod { get; set; }

    public DateTime? DtCosmos { get; set; }

    public DateTime? DtActualizado { get; set; }

    public string? BillDtaccount { get; set; }

    public decimal? Peso { get; set; }

    public int? IdUpeso { get; set; }

    public decimal? PesoVol { get; set; }

    public int? IdUpesoVol { get; set; }

    public decimal? Comprimento { get; set; }

    public decimal? Largura { get; set; }

    public decimal? Altura { get; set; }

    public int? IdUdims { get; set; }

    public string? Macro { get; set; }

    public int? IdTipoDangGoods { get; set; }

    public decimal? CustoFuel { get; set; }

    public decimal? CustoSeguro { get; set; }

    public int? IdServico { get; set; }

    public int? IdCliMorada { get; set; }
}
