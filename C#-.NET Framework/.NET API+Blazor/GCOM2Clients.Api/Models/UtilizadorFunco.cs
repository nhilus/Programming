using System;
using System.Collections.Generic;

namespace GCOM2Users.Models;

public partial class UtilizadorFunco
{
    public int IdUtil { get; set; }

    public int IdFuncao { get; set; }

    public bool IsLider { get; set; }
}
