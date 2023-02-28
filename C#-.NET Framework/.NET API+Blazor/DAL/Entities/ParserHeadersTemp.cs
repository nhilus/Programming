using System;
using System.Collections.Generic;

namespace DAL.Entities;

public partial class ParserHeadersTemp
{
    public int Id { get; set; }

    public DateTime? CreationDate { get; set; }

    public int? IdCliente { get; set; }

    public string? ContribDest { get; set; }

    public string? NomeDest { get; set; }

    public string? MoradaDest { get; set; }

    public string? LocalidadeDest { get; set; }

    public string? CodPostalDest { get; set; }

    public string? LocalCodPostalDest { get; set; }

    public string? TelefoneDest { get; set; }

    public int? NVols { get; set; }

    public decimal? Peso { get; set; }

    public decimal? M3 { get; set; }

    public int? TipoEmbalagem { get; set; }

    public string? RefCliente { get; set; }

    public string? Mercadoria { get; set; }

    public decimal? ReembVal { get; set; }

    public decimal? MercadoriaVal { get; set; }

    public string? SerieGuia { get; set; }

    public string? Guia { get; set; }

    public string? Obs { get; set; }

    public DateTime? DataEntregaDest { get; set; }

    public string? Moeda { get; set; }

    public string? ReembolsoObs { get; set; }

    public string? Departamento { get; set; }

    public string? ContribExp { get; set; }

    public string? NomeExp { get; set; }

    public string? MoradaExp { get; set; }

    public string? LocalidadeExp { get; set; }

    public string? CodPostalExp { get; set; }

    public string? LocalExp { get; set; }

    public int? TipoServico { get; set; }

    public int? TipoTrafego { get; set; }

    public string? NumGt { get; set; }

    public int? DocExpAss { get; set; }

    public bool? GrandeSup { get; set; }

    public int? IdClienteFacturacao { get; set; }

    public bool? ImprimirGuia { get; set; }

    public string? AwbCliente { get; set; }

    public bool? GerarRecolha { get; set; }

    public DateTime? DtEnvio { get; set; }

    public int? IdSegmento { get; set; }

    public int? ClasseOrigem { get; set; }
}
