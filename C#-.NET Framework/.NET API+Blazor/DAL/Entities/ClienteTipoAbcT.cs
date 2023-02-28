using System;
using System.Collections.Generic;

namespace DAL.Entities;

public partial class ClienteTipoAbcT
{
    public int Id { get; set; }

    public string Codigo { get; set; } = null!;

    public string Descricao { get; set; } = null!;

    public int IdEntidade { get; set; }

    public decimal ValorMin { get; set; }

    public decimal ValorMax { get; set; }

    public string Color { get; set; } = null!;

    public bool? Activo { get; set; }
}
