using System;
using System.Collections.Generic;

namespace DAL.Entities;

public partial class LineHaulTipoT
{
    public int Id { get; set; }

    public string? Descricao { get; set; }

    public int IdEntidade { get; set; }

    public bool? Activo { get; set; }

    public bool? Aerea { get; set; }

    public int? IdVia { get; set; }
}
