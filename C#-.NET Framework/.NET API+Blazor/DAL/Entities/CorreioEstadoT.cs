using System;
using System.Collections.Generic;

namespace DAL.Entities;

public partial class CorreioEstadoT
{
    public int Id { get; set; }

    public string Nome { get; set; } = null!;

    public string? Descricao { get; set; }

    public bool? Activo { get; set; }

    public bool Finaliza { get; set; }
}
