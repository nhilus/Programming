using System;
using System.Collections.Generic;

namespace GCOM2Users.Models;

public partial class AeroportoT
{
    public int Id { get; set; }

    public string Codigo { get; set; } = null!;

    public string Descricao { get; set; } = null!;

    public string Sigla { get; set; } = null!;

    public int IdPais { get; set; }

    public bool? Activo { get; set; }
}
