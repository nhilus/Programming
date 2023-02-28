using System;
using System.Collections.Generic;

namespace DAL.Entities;

public partial class ConferenciaCustosEnvio
{
    public int Id { get; set; }

    public int IdConferenciaCustosFactura { get; set; }

    public string? Awb { get; set; }

    public string? TipoServico { get; set; }

    public int? IdCliente { get; set; }

    public int? IdServico { get; set; }

    public DateTime? DataEnvio { get; set; }

    public decimal? ValorLiquido { get; set; }

    public int? IdMoeda { get; set; }

    public int? NumVolumes { get; set; }

    public int? IdLocPagaTransporte { get; set; }

    public decimal? PesoFacturado { get; set; }

    public decimal? PesoOriginal { get; set; }

    public string? UnidadePeso { get; set; }

    public string? Referencia1 { get; set; }

    public string? Referencia2 { get; set; }

    public string? Referencia3 { get; set; }

    public string? Euvatnumber { get; set; }

    public string? ImportObjectName { get; set; }

    public int? ImportObjectId { get; set; }

    public int? IdManifesto { get; set; }

    public decimal? CustoPrevistoOriginal { get; set; }

    public decimal? CustoPrevisto { get; set; }

    public decimal? CustoReal { get; set; }

    public decimal? ValorFacturado { get; set; }

    public decimal? ValorFacturadoOriginal { get; set; }

    public decimal? CustoDadosDlink { get; set; }

    public decimal? ValorFactDadosDlink { get; set; }

    public bool Conferida { get; set; }

    public DateTime? DtConferida { get; set; }

    public int? IdUtilConferida { get; set; }

    public int? IdTipoConferencia { get; set; }

    public string? Observacoes { get; set; }
}
