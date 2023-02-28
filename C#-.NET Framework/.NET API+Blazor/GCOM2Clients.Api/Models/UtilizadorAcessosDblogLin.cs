using System;
using System.Collections.Generic;

namespace GCOM2Users.Models;

public partial class UtilizadorAcessosDblogLin
{
    public long Id { get; set; }

    public long IdLog { get; set; }

    public DateTime Data { get; set; }

    public byte Passo { get; set; }
}
