using System;
using System.Collections.Generic;

namespace DAL.Entities;

public partial class GuiasImprimirLog
{
    public int Pk { get; set; }

    public string? FileName { get; set; }

    public DateTime? DataParam { get; set; }

    public int? IdRotaParam { get; set; }

    public bool? TodasParam { get; set; }

    public bool? PlaneadasParam { get; set; }

    public int? IdUtilReq { get; set; }

    public string? AwbParam { get; set; }

    public string? IdsParam { get; set; }

    public int? IdPlataformaParam { get; set; }

    public bool? PlataformaTodaParam { get; set; }

    public int? Id { get; set; }

    public string? AwbNumber { get; set; }

    public string? MasterNumber { get; set; }

    public string? RemRefCli { get; set; }

    public string? NomeCliente { get; set; }

    public string? MoradaCliente { get; set; }

    public string? LocalidadeCliente { get; set; }

    public string? CodPostalCliente { get; set; }

    public string? PaisCliente { get; set; }

    public string? ContactoCliente { get; set; }

    public string? NomeDestinatario { get; set; }

    public string? MoradaDestinatario { get; set; }

    public string? LocalidadeDestinatario { get; set; }

    public string? CodPostalDestinatario { get; set; }

    public string? PaisDestinatario { get; set; }

    public string? ContactoDestinatario { get; set; }

    public int? Volume { get; set; }

    public string? Peso { get; set; }

    public string? Cubicagem { get; set; }

    public string? TipoProduto { get; set; }

    public string? TipoEmbalagem { get; set; }

    public string? TipoServico { get; set; }

    public string? Observacoes { get; set; }

    public int? Ano { get; set; }

    public int? Mes { get; set; }

    public int? Dia { get; set; }

    public decimal? ValorPrevisto { get; set; }

    public decimal? ValorReemb { get; set; }

    public int? Logo { get; set; }

    public string? LocalPagamento { get; set; }

    public int? DevGuiaAss { get; set; }

    public DateTime? DtIntrod { get; set; }

    public DateTime? DtConfirmaImpressao { get; set; }

    public bool? ScanGuiaImpressa { get; set; }

    public int? IdPickup { get; set; }
}
