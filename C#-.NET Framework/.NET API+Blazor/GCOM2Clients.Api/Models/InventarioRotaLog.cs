using System;
using System.Collections.Generic;

namespace GCOM2Users.Models;

public partial class InventarioRotaLog
{
    public int? IdUtil { get; set; }

    public string? Awb { get; set; }

    public string? Scan { get; set; }

    public int? Idplataforma { get; set; }

    public string? Rota { get; set; }

    public DateTime? DtIntrod { get; set; }

    public string? Observacoes { get; set; }
}
