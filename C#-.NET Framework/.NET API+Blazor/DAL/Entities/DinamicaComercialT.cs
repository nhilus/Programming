using System;
using System.Collections.Generic;

namespace DAL.Entities;

public partial class DinamicaComercialT
{
    public int Id { get; set; }

    public int? IdEntidade { get; set; }

    public string? Codigo { get; set; }

    public string? Descricao { get; set; }

    public bool? Activo { get; set; }

    public bool? IsDefault { get; set; }
}
