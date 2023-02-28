using System;
using System.Collections.Generic;

namespace GCOM2Users.Models;

public partial class FedexTarifa
{
    public int? IdCliente { get; set; }

    public int? IdRegime { get; set; }

    public int? IdServico { get; set; }

    public string? Codigo { get; set; }
}
