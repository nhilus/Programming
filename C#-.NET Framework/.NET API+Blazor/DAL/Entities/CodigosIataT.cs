using System;
using System.Collections.Generic;

namespace DAL.Entities;

public partial class CodigosIataT
{
    public string Codigo { get; set; } = null!;

    public string? Pais { get; set; }

    public int IdPais { get; set; }

    public bool? Default { get; set; }
}
