using System;
using System.Collections.Generic;

namespace DAL.Entities;

public partial class ConferenciaCustosVolume
{
    public int Id { get; set; }

    public int IdConferenciaCustosEnvios { get; set; }

    public string? UnidadePeso { get; set; }

    public decimal? Peso { get; set; }

    public decimal? PesoOriginal { get; set; }

    public int? Comprimento { get; set; }

    public int? Largura { get; set; }

    public int? Altura { get; set; }

    public string? UnidadeMedida { get; set; }

    public int? Divisor { get; set; }

    public int? ValorDeclarado { get; set; }

    public decimal? ValorAlfandega { get; set; }

    public string? Moeda { get; set; }

    public string? ImportObjectName { get; set; }

    public int? ImportObjectId { get; set; }
}
