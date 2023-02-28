using System;
using System.Collections.Generic;

namespace DAL.Entities;

public partial class ManifestoFact
{
    public int IdManifesto { get; set; }

    public string Awb { get; set; } = null!;

    public bool? IsMaster { get; set; }

    public DateTime? DtEnvio { get; set; }

    public byte IdEntidade { get; set; }

    public int? IdCliente { get; set; }

    public int? IdCliMorada { get; set; }

    public int? IdClienteFact { get; set; }

    public int? IdCliMoradaFact { get; set; }

    public int? IdClienteEmissao { get; set; }

    public int? IdCliMoradaEmissao { get; set; }

    public byte? IdRegime { get; set; }

    public byte? IdServico { get; set; }

    public short? IdClasseOrigem { get; set; }

    public string? CPostalOrigem { get; set; }

    public short? IdPaisOrigem { get; set; }

    public string? CPostalDestino { get; set; }

    public short? IdPaisDestino { get; set; }

    public short? IdTipoProduto { get; set; }

    public short? NumPacotes { get; set; }

    public double? Peso { get; set; }

    public double? PesoVol { get; set; }

    public double? M3 { get; set; }

    public decimal? Comprimento { get; set; }

    public decimal? Largura { get; set; }

    public decimal? Altura { get; set; }

    public string? Observacoes { get; set; }

    public bool ValidToFact { get; set; }

    public DateTime? DtValidToFact { get; set; }

    public bool? ParaFacturar { get; set; }

    public DateTime? DtParaFacturar { get; set; }

    public short? IdUtilParaFacturar { get; set; }

    public byte? IdMotivoParaFacturar { get; set; }

    public int? IdAgrupamento { get; set; }

    public DateTime? DtUltAct { get; set; }

    public short? IdUtilUltAct { get; set; }

    public bool? FacturacaoIndividual { get; set; }

    public string? ContaPagaTrans { get; set; }

    public byte? IdLocPagaTrans { get; set; }

    public string? ObsVendaDinheiro { get; set; }

    public bool VendaDinheiro { get; set; }

    public string? RefExpedidor { get; set; }

    public string? DepartamentoFact { get; set; }

    public decimal? ValorMercadoria { get; set; }

    public DateTime? DtProduto { get; set; }
}
