using System;
using System.Collections.Generic;

namespace DAL.Entities;

public partial class LineHaulPlataformaT
{
    public int Id { get; set; }

    public string? Codigo { get; set; }

    public string? Descricao { get; set; }

    public int? IdPais { get; set; }

    public int IdEntidade { get; set; }

    public bool? Activo { get; set; }

    public int? IdPlat { get; set; }

    public string? CodCurto { get; set; }
}
