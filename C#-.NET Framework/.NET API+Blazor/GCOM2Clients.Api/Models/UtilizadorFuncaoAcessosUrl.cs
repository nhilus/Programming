using System;
using System.Collections.Generic;

namespace GCOM2Users.Models;

public partial class UtilizadorFuncaoAcessosUrl
{
    public int Id { get; set; }

    public int IdFuncao { get; set; }

    public int IdMenuUrl { get; set; }

    public bool? IsVisible { get; set; }

    public bool? Activo { get; set; }

    public bool IsDefault { get; set; }
}
