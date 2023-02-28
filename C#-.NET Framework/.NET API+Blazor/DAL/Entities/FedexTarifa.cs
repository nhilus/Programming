using System;
using System.Collections.Generic;

namespace DAL.Entities;

public partial class FedexTarifa
{
    public int? IdCliente { get; set; }

    public int? IdRegime { get; set; }

    public int? IdServico { get; set; }

    public string? Codigo { get; set; }
}
