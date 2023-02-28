using System;
using System.Collections.Generic;

namespace GCOM2Users.Models;

public partial class MenuUrlT
{
    public int Id { get; set; }

    public string Url { get; set; } = null!;

    public string? Descricao { get; set; }

    public bool? Activo { get; set; }

    public string? DescricaoLonga { get; set; }

    public byte TipoClienteBar { get; set; }
}
