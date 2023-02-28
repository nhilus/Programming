using System;
using System.Collections.Generic;

namespace DAL.Entities;

public partial class CargoScannerBalancasT
{
    public string IdBalanca { get; set; } = null!;

    public string? Descricao { get; set; }

    public int? IdPlataforma { get; set; }

    public int? IdTipoBalanca { get; set; }

    public string? DescReport { get; set; }

    public int? IdEntidade { get; set; }

    public bool? Activa { get; set; }

    public int? IdUtil { get; set; }
}
