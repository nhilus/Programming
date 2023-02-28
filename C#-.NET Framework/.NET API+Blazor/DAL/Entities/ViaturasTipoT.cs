using System;
using System.Collections.Generic;

namespace DAL.Entities;

public partial class ViaturasTipoT
{
    public int Id { get; set; }

    public string? Codigo { get; set; }

    public decimal? AlturaMax { get; set; }

    public int? IdUnidadeMetricaAlturaMax { get; set; }

    public decimal? ComprimentoMax { get; set; }

    public int? IdUnidadeMetricaComprimentoMax { get; set; }

    public string? Imagem { get; set; }

    public string? Imagem2 { get; set; }
}
