using System;
using System.Collections.Generic;

namespace DAL.Entities;

public partial class TempStatusConvert
{
    public int IdCliMorada { get; set; }

    public int IdCliente { get; set; }

    public int? IdStatus { get; set; }

    public bool? Processado { get; set; }
}
