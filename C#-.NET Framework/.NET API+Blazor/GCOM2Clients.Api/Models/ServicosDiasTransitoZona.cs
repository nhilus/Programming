using System;
using System.Collections.Generic;

namespace GCOM2Users.Models;

public partial class ServicosDiasTransitoZona
{
    public int Id { get; set; }

    public int IdServico { get; set; }

    public string Zona { get; set; } = null!;

    public int IdPais { get; set; }

    public string? Cpostal0 { get; set; }

    public string? Cpostal1 { get; set; }
}
