using System;
using System.Collections.Generic;

namespace DAL.Entities;

public partial class PaisZonaRegioesT
{
    public int Id { get; set; }

    public string Descricao { get; set; } = null!;

    public bool? Ec { get; set; }

    public bool? Activo { get; set; }
}
