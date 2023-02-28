using System;
using System.Collections.Generic;

namespace DAL.Entities;

public partial class TiagoCostum
{
    public int IdManifesto { get; set; }

    public string? Awb { get; set; }

    public DateTime? DtEnvio { get; set; }

    public int? IdCliente { get; set; }

    public string? Cliente { get; set; }

    public int? IdTarifa { get; set; }

    public string? Tarifa { get; set; }

    public decimal? ValorFact { get; set; }

    public bool? ValorManual { get; set; }

    public string? TarifaSimulada { get; set; }

    public decimal? ValorSimulado { get; set; }

    public string? Servico { get; set; }
}
