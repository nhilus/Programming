using System;
using System.Collections.Generic;

namespace GCOM2Users.Models;

public partial class TempStatusConvert
{
    public int IdCliMorada { get; set; }

    public int IdCliente { get; set; }

    public int? IdStatus { get; set; }

    public bool? Processado { get; set; }
}
