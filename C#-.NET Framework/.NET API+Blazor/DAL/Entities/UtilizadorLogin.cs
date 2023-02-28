using System;
using System.Collections.Generic;

namespace DAL.Entities;

public partial class UtilizadorLogin
{
    public int IdUtil { get; set; }

    public string Login { get; set; } = null!;

    public string Password { get; set; } = null!;

    public bool LoginEnabled { get; set; }

    public DateTime DtPassword { get; set; }

    public int DuracaoPassword { get; set; }

    public int IdUtilUltAct { get; set; }

    public DateTime DtUltAct { get; set; }
}
