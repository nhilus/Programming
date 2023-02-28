using System;
using System.Collections.Generic;

namespace DAL.Entities;

public partial class UtilizadorFunco
{
    public int IdUtil { get; set; }

    public int IdFuncao { get; set; }

    public bool IsLider { get; set; }
}
