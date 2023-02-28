using System;
using System.Collections.Generic;

namespace DAL.Entities;

public partial class ParserCexReembolso
{
    public int Id { get; set; }

    public string? NumEnvio { get; set; }

    public DateTime? DtEnvio { get; set; }

    public int? Producto { get; set; }

    public string? CodRem { get; set; }

    public string? Referencia { get; set; }

    public string? NomeRem { get; set; }

    public string? MoradaRem { get; set; }

    public string? LocalidadeRem { get; set; }

    public string? CpostalRem { get; set; }

    public string? TlfRem { get; set; }

    public string? NomeDest { get; set; }

    public string? MoradaDest { get; set; }

    public string? LocalidadeDest { get; set; }

    public string? CpostalDest { get; set; }

    public string? TelfDest { get; set; }

    public int? Numpacotes { get; set; }

    public decimal? Peso { get; set; }

    public string? CodEstadoEnvio { get; set; }

    public string? DescricaoEstadoEnvio { get; set; }

    public string? ValorFixo { get; set; }

    public decimal? Reembolso { get; set; }

    public int? NrFactura { get; set; }

    public int? Cheque { get; set; }

    public string? Obs { get; set; }

    public int? SituacaoReembolso { get; set; }

    public DateTime? DtFechoFacturacao { get; set; }

    public DateTime? DtFechoEstadoenvio { get; set; }

    public string? NomeFicheiro { get; set; }

    public DateTime? DtInsert { get; set; }

    public int? Processado { get; set; }

    public DateTime? Dtprocessado { get; set; }

    public string? MsgProcessamento { get; set; }
}
