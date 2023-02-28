using System;
using System.Collections.Generic;

namespace GCOM2Users.Models;

public partial class UtilizadorFuncaoEntidadeAcessosUrlParam
{
    public int Id { get; set; }

    public int IdUfeacessoUrl { get; set; }

    public string Codigo { get; set; } = null!;

    public object Valor { get; set; } = null!;
}
