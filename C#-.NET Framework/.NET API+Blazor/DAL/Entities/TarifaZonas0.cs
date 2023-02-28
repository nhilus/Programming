using System;
using System.Collections.Generic;

namespace DAL.Entities;

public partial class TarifaZonas0
{
    public int Id { get; set; }

    public int IdTarifa { get; set; }

    public string Zona { get; set; } = null!;

    public int IdPais { get; set; }

    public string? Cpostal0 { get; set; }

    public string? Cpostal1 { get; set; }
}
