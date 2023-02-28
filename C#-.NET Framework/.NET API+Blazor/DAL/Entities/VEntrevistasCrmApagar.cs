using System;
using System.Collections.Generic;

namespace DAL.Entities;

public partial class VEntrevistasCrmApagar
{
    public int Id { get; set; }

    public DateTime? DtInicio { get; set; }

    public int? IdUtil { get; set; }

    public int IdCliente { get; set; }

    public string Nome { get; set; } = null!;

    public bool? NaoAtendeu { get; set; }

    public short? Duracao { get; set; }

    public string? Observacoes { get; set; }

    public int? IdFormato { get; set; }

    public string Formato { get; set; } = null!;

    public int? IdTipo { get; set; }

    public string Tipo { get; set; } = null!;

    public bool? Automatica { get; set; }

    public bool? Remarcada { get; set; }

    public int IdEntrevistaOrigem { get; set; }

    public int IdEntrevistaResposta { get; set; }

    public bool? Efectuada { get; set; }

    public int? IdAlerta { get; set; }
}
