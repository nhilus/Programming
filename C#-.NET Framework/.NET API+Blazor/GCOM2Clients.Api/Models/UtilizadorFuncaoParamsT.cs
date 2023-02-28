using System;
using System.Collections.Generic;

namespace GCOM2Users.Models;

public partial class UtilizadorFuncaoParamsT
{
    public int Id { get; set; }

    public byte IdUtilizadorFuncao { get; set; }

    public string Codigo { get; set; } = null!;

    public object Valor { get; set; } = null!;
}
