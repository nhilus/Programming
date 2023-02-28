using System;
using System.Collections.Generic;

namespace DAL.Entities;

public partial class CodigosPostaisZonasPaisT
{
    public int Id { get; set; }

    public int IdPais { get; set; }

    public string Sigla { get; set; } = null!;

    public string Descricao { get; set; } = null!;

    public bool Activo { get; set; }
}
