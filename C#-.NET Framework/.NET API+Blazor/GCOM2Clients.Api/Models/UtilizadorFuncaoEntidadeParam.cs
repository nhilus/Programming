using System;
using System.Collections.Generic;

namespace GCOM2Users.Models;

public partial class UtilizadorFuncaoEntidadeParam
{
    public int Id { get; set; }

    public short IdUtilizadorFuncaoEntidade { get; set; }

    public string Codigo { get; set; } = null!;

    public object Valor { get; set; } = null!;
}
