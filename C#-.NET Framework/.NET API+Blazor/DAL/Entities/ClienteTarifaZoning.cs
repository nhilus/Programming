using System;
using System.Collections.Generic;

namespace DAL.Entities;

public partial class ClienteTarifaZoning
{
    public int Id { get; set; }

    public int IdTarifa { get; set; }

    public int IdPais { get; set; }

    public string Zona { get; set; } = null!;
}
