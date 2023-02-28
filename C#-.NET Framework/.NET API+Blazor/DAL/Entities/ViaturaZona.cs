using System;
using System.Collections.Generic;

namespace DAL.Entities;

public partial class ViaturaZona
{
    public int Id { get; set; }

    public int IdViatura { get; set; }

    public int IdPais { get; set; }

    public string? Cpostal0 { get; set; }

    public string? Cpostal1 { get; set; }
}
