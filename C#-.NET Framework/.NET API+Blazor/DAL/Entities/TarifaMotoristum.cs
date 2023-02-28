using System;
using System.Collections.Generic;

namespace DAL.Entities;

public partial class TarifaMotoristum
{
    public int Id { get; set; }

    public int IdTarifa { get; set; }

    public decimal? ValorDia { get; set; }

    public decimal? NumStops { get; set; }

    public bool? Activo { get; set; }

    public int? IdUtilIntrod { get; set; }

    public DateTime? DtIntrod { get; set; }

    public decimal? ValorStop { get; set; }
}
