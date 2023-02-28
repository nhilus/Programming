using System;
using System.Collections.Generic;

namespace DAL.Entities;

public partial class ExportacaoManifestoFsm
{
    public int Id { get; set; }

    public int? Idpickup { get; set; }

    public DateTime? RouteDate { get; set; }

    public int? IdAviao { get; set; }

    public string? MasterNumber { get; set; }

    public string? AwbNumber { get; set; }

    public string? FormId { get; set; }

    public int? IdPlataforma { get; set; }

    public string? IdEstacaoDestino { get; set; }

    public DateTime? DtEnvio { get; set; }

    public int? ShNumContaFedex { get; set; }

    public string? ShNome { get; set; }

    public string? ShReferencia { get; set; }

    public string? CoNome { get; set; }

    public string? CoTelefone { get; set; }

    public string? CoEmpresa { get; set; }

    public string? CoDepartamento { get; set; }

    public string? CoMorada { get; set; }

    public string? CoCidade { get; set; }

    public string? CoEstado { get; set; }

    public int? IdCoCpostal { get; set; }

    public string? CoCpostal { get; set; }

    public int? IdCoPais { get; set; }

    public int? IdfedexServiceType { get; set; }

    public string? FedexHandlingCode { get; set; }

    public string? FedexHandlingCode2 { get; set; }

    public bool? DangerousGoodsFlag { get; set; }

    public bool? CargoAircraftOnly { get; set; }

    public string? BrNome { get; set; }

    public string? BrCidade { get; set; }

    public int? IdBrPais { get; set; }

    public string? BrTelefone { get; set; }

    public string? BrCpostal { get; set; }

    public int? IdTransportCharges { get; set; }

    public string? TcAccount { get; set; }

    public int? IdDutiesTaxes { get; set; }

    public string? DtxAccount { get; set; }

    public short? NumPacotes { get; set; }

    public decimal? Comprimento { get; set; }

    public decimal? Largura { get; set; }

    public decimal? Altura { get; set; }

    public int? IdUnidadeMetrica { get; set; }

    public decimal? Peso { get; set; }

    public short? IdUnidadePeso { get; set; }

    public short? IdMoeda { get; set; }

    public decimal? ValorCarriage { get; set; }

    public decimal? ValorAlfandega { get; set; }

    public bool? Seguro { get; set; }

    public string? Descricao { get; set; }

    public bool? NonComercialFlag { get; set; }

    public short? ReceivedAt { get; set; }

    public bool? ExtractedForTransfer { get; set; }

    public string? HarmonizedCode { get; set; }

    public int? IdPaisManufactura { get; set; }

    public bool? ExportLicense { get; set; }

    public decimal? TotalCharges { get; set; }

    public decimal? PesoVolumetrico { get; set; }

    public short? IdUnidadePesoVolumetrico { get; set; }

    public int? BatchNumber { get; set; }

    public bool? ThermalAwb { get; set; }

    public int? Cflag { get; set; }

    public int? IdTipoProduto { get; set; }

    public bool? VendaDinheiro { get; set; }

    public decimal? ValorVendaDinheiro { get; set; }

    public bool? Fef { get; set; }

    public decimal? ValorFef { get; set; }

    public decimal? ValorReembolso { get; set; }

    public bool? Ipf { get; set; }

    public int? IdServicoDom { get; set; }

    public int? IdCliente { get; set; }

    public int? IdTarifa { get; set; }

    public bool FacturacaoIndividual { get; set; }

    public bool? ValidToFact { get; set; }

    public DateTime? DtValidToFact { get; set; }

    public int? IdUtilValidToFact { get; set; }

    public bool? ExpToFact { get; set; }

    public DateTime? DtExpToFact { get; set; }

    public int? IdUtilExpToFact { get; set; }

    public bool? ValidToGrasp { get; set; }

    public DateTime? DtValidToGrasp { get; set; }

    public int? IdUtilValidToGrasp { get; set; }

    public bool? ExpToGrasp { get; set; }

    public DateTime? DtExpToGrasp { get; set; }

    public int? IdUtilExpToGrasp { get; set; }

    public int? IdUtilIntrod { get; set; }

    public DateTime? DtIntrod { get; set; }

    public DateTime? DtDu { get; set; }

    public int? IdUtilDu { get; set; }

    public string? ObservacoesDu { get; set; }

    public int IdEntidade { get; set; }

    public int? IdDistribuidor { get; set; }

    public int? IdUtilUltAct { get; set; }

    public DateTime? DtUltAct { get; set; }

    public decimal? CustoPrevisto { get; set; }

    public DateTime? DtCustoPrevisto { get; set; }

    public decimal? CustoReal { get; set; }

    public DateTime? DtCustoReal { get; set; }

    public string? ObsCusto { get; set; }

    public DateTime? ShipDateFsm { get; set; }

    public int? ShNumContaFedexFsm { get; set; }

    public string? ShNomeFsm { get; set; }

    public string? ShReferenciaFsm { get; set; }

    public string? ShPaisFsm { get; set; }

    public string? CoNomeFsm { get; set; }

    public string? CoEmpresaFsm { get; set; }

    public string? CoTelefoneFsm { get; set; }

    public string? CoMorada1Fsm { get; set; }

    public string? CoMorada2Fsm { get; set; }

    public string? CoCidadeFsm { get; set; }

    public string? CoPaisFsm { get; set; }

    public string? CoCpostalFsm { get; set; }

    public string? HoldAtFedexFsm { get; set; }

    public short? NumPacotesFsm { get; set; }

    public decimal? PesoFsm { get; set; }

    public string? UnidadePesoFsm { get; set; }

    public decimal? PesoVolumetricoFsm { get; set; }

    public string? UnidadePesoVolumetricoFsm { get; set; }

    public string? DescricaoFsm { get; set; }

    public string? HarmonizedCodeFsm { get; set; }

    public string? PaisManufactura { get; set; }

    public decimal? ValorCarriageFsm { get; set; }

    public string? MoedaFsm { get; set; }

    public decimal? ValorAlfandegaFsm { get; set; }

    public string? SvcFsm { get; set; }

    public string? TipoProdutoFsm { get; set; }

    public string? TransportChargesFsm { get; set; }

    public string? TcAccountFsm { get; set; }

    public string? DutiesTaxesFsm { get; set; }

    public string? DtxAccountFsm { get; set; }

    public string? FormIdFsm { get; set; }

    public string? PlataformaFsm { get; set; }

    public string? EstacaoDestinoFsm { get; set; }

    public short? ReceivedAtFsm { get; set; }

    public int? IdServico { get; set; }

    public int? IdCliMorada { get; set; }
}
