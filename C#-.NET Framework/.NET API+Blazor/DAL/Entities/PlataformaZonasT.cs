using System;
using System.Collections.Generic;

namespace DAL.Entities;

public partial class PlataformaZonasT
{
    public int Id { get; set; }

    public int IdPlataforma { get; set; }

    public string Zona { get; set; } = null!;

    public int? CodPlataformaAgente { get; set; }

    public string? CodPostalDefault { get; set; }
}
