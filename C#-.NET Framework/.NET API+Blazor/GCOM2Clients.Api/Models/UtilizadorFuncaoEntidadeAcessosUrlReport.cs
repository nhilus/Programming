using System;
using System.Collections.Generic;

namespace GCOM2Users.Models;

public partial class UtilizadorFuncaoEntidadeAcessosUrlReport
{
    public int Id { get; set; }

    public int IdUtilizadorFuncaoEntidade { get; set; }

    public int IdMenuReport { get; set; }

    public bool? IsVisible { get; set; }

    public bool? Activo { get; set; }

    public bool IsDefault { get; set; }
}
