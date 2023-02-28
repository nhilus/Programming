using System;
using System.Collections.Generic;

namespace DAL.Entities;

public partial class ViewFacturacaoRexIi
{
    public string? Nome { get; set; }

    public string Awb { get; set; } = null!;

    public DateTime? DtEnvio { get; set; }

    public string? Servico { get; set; }

    public short? NumPacotes { get; set; }

    public decimal? Peso { get; set; }

    public double? M3 { get; set; }

    public string? CpostalOrigem { get; set; }

    public string? PaisOrigem { get; set; }

    public string? CpostalDestino { get; set; }

    public string? PaisDestino { get; set; }

    public string? ClientFact { get; set; }

    public decimal ValorFact { get; set; }

    public int? CodAgrupamento { get; set; }

    public DateTime? Data { get; set; }
}
