using System;
using System.Collections.Generic;

namespace GCOM2Users.Models;

public partial class TarifaClienteFicheiro
{
    public int? IdCliente { get; set; }

    public int? IdTarifa { get; set; }

    public string? Servico { get; set; }

    public string? Ficheiro { get; set; }
}
