using System;
using System.Collections.Generic;

namespace DAL.Entities;

public partial class CrossDockingFacturacaoT
{
    public int? IdCliente { get; set; }

    public string? NomeClienteFact { get; set; }

    public int? IdClienteFact { get; set; }

    public int? IdCliMorada { get; set; }

    public int? IdEntidade { get; set; }
}
