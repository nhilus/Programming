using System;
using System.Collections.Generic;

namespace GCOM2Users.Models;

public partial class TarifasSimular
{
    public int Id { get; set; }

    public int? IdCliente { get; set; }

    public int? IdEntidade { get; set; }

    public int? IdRegime { get; set; }

    public int? IdServico { get; set; }

    public string? TextoTarifa { get; set; }

    public double? Aumento { get; set; }

    public decimal? ValorAntigo { get; set; }

    public decimal? ValorSimulado { get; set; }

    public int? IdTarifa { get; set; }
}
