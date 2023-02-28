using System;
using System.Collections.Generic;

namespace DAL.Entities;

public partial class SalesLeadsMotivosT
{
    public int? Id { get; set; }

    public string? Codigo { get; set; }

    public string? Descricao { get; set; }

    public string? Modulo { get; set; }

    public bool? Activo { get; set; }
}
