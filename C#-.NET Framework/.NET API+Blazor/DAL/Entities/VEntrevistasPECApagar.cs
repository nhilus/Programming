using System;
using System.Collections.Generic;

namespace DAL.Entities;

public partial class VEntrevistasPECApagar
{
    public int Id { get; set; }

    public DateTime? Data { get; set; }

    public int? IdUtil { get; set; }

    public int IdCliente { get; set; }

    public string Nome { get; set; } = null!;

    public int? NaoAtendeu { get; set; }

    public int? Duracao { get; set; }

    public string? Observacoes { get; set; }

    public int? IdFormato { get; set; }

    public string? Formato { get; set; }

    public int? IdTipo { get; set; }

    public string? Tipo { get; set; }

    public bool? Automatica { get; set; }

    public bool? Remarcada { get; set; }

    public int? IdEntrevistaOrigem { get; set; }

    public int IdEntrevistaResposta { get; set; }

    public bool? Efectuada { get; set; }

    public int? IdAlerta { get; set; }

    public string Pec { get; set; } = null!;
}
