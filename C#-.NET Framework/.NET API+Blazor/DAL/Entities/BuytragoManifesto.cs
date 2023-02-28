using System;
using System.Collections.Generic;

namespace DAL.Entities;

public partial class BuytragoManifesto
{
    public string? CodDelOrig { get; set; }

    public string? CodDelDest { get; set; }

    public string? CodEtiquetado { get; set; }

    public string? NumExpedicao { get; set; }

    public string? CodExpedidor { get; set; }

    public string? NumDocCliente { get; set; }

    public int? DocAnexo { get; set; }

    public int? TipoRegisto { get; set; }

    public int? TipoEnvio { get; set; }

    public int? TipoAvaliacao { get; set; }

    public int? TipoServico { get; set; }

    public string? NomeExpedidor { get; set; }

    public string? MoradaExpedidor { get; set; }

    public string? LocalidadeExpedidor { get; set; }

    public string? NomeRemetente { get; set; }

    public string? CodDelRemetente { get; set; }

    public string? NomeDest { get; set; }

    public string? Morada1Dest { get; set; }

    public string? Morada2Det { get; set; }

    public string? LocalidadeDest { get; set; }

    public string? CodPostalDest { get; set; }

    public int? NumVols { get; set; }

    public int? NumEtiq { get; set; }

    public decimal? Peso { get; set; }

    public decimal? M3 { get; set; }

    public decimal? PesoVol { get; set; }

    public string? Conteudo { get; set; }

    public decimal? Porte { get; set; }

    public decimal? ReExpComercial { get; set; }

    public decimal? Seguro { get; set; }

    public decimal? GastosReembolsoPortePagado { get; set; }

    public decimal? ValorSegurado { get; set; }

    public decimal? GastosSeguroMercadoria { get; set; }

    public decimal? Iva { get; set; }

    public decimal? Desembolso { get; set; }

    public decimal? Reembolso { get; set; }

    public decimal? GastosReembolsoPorteDevido { get; set; }

    public decimal? IvaPorteDevido { get; set; }

    public decimal? ReExpInterna { get; set; }

    public string? Control1 { get; set; }

    public string? Control2 { get; set; }

    public decimal? PercentDesconto { get; set; }

    public bool? ComIva { get; set; }

    public DateTime? DataExpedicao { get; set; }

    public int? NumRota { get; set; }

    public string? Obs { get; set; }

    public DateTime? Ded { get; set; }

    public string? ContactoDest { get; set; }

    public string? TelfDest { get; set; }

    public string? CodPaisExpedidor { get; set; }

    public string? CodPostalExpedidor { get; set; }

    public int? IdHeader { get; set; }

    public int? IdManifesto { get; set; }

    public DateTime? DtIntrod { get; set; }
}
