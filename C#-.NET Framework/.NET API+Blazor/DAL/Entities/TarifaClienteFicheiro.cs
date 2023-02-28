using System;
using System.Collections.Generic;

namespace DAL.Entities;

public partial class TarifaClienteFicheiro
{
    public int? IdCliente { get; set; }

    public int? IdTarifa { get; set; }

    public string? Servico { get; set; }

    public string? Ficheiro { get; set; }
}
