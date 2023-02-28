using System;
using System.Collections.Generic;

namespace DAL.Entities;

public partial class ParserHeadersLog
{
    public int Id { get; set; }

    public DateTime BckDate { get; set; }

    public int IdHeader { get; set; }

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

    public double? M3 { get; set; }

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

    public int? LineIndex { get; set; }

    public string? FileName { get; set; }

    public decimal? ValorSegurado { get; set; }

    public int? IdPaisOrigem { get; set; }

    public int? IdPaisDestino { get; set; }

    public DateTime? DataOrigem { get; set; }

    public int? LocalPagamento { get; set; }

    public bool? VendaDinheiro { get; set; }

    public string? RefOrigem { get; set; }

    public string? Email { get; set; }

    public int? IdCliMorada { get; set; }

    public int? IdEntidade { get; set; }

    public bool? RecolhaRemota { get; set; }

    public string? RefGeodis { get; set; }

    public string? NomeContactoDest { get; set; }

    public bool? ActualizaDados { get; set; }

    public int? Swap { get; set; }

    public bool? PrevEntrega { get; set; }

    public bool? PrevRecolha { get; set; }

    public int? IdRecolha { get; set; }

    public bool? SendEmail { get; set; }

    public int? IdProvedor { get; set; }

    public string? NumEnvioDevolvido { get; set; }
}
