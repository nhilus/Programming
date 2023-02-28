using System;
using System.Collections.Generic;

namespace DAL.Entities;

public partial class Tarifassimular2016
{
    public int? Idcliente { get; set; }

    public byte? Identidade { get; set; }

    public int? IdRegime { get; set; }

    public int? IdServico { get; set; }

    public string? TextoTarifa { get; set; }

    public decimal? Aumento { get; set; }

    public decimal? ValorAntigo { get; set; }

    public decimal? ValorSimulado { get; set; }

    public int? IdTarifa { get; set; }
}
