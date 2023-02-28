using System;
using System.Collections.Generic;

namespace DAL.Entities;

public partial class AvisoTipoT
{
    public int Id { get; set; }

    public string Nome { get; set; } = null!;

    public string? Descricao { get; set; }

    public bool? Activo { get; set; }
}
