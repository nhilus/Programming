using System;
using System.Collections.Generic;

namespace DAL.Entities;

public partial class ClientePropriedadeT
{
    public int Id { get; set; }

    public string Descricao { get; set; } = null!;

    public string? TipoValor { get; set; }

    public object? ValorInicial { get; set; }

    public int? Posicao { get; set; }

    public bool? Activo { get; set; }

    public int IdEntidade { get; set; }
}
