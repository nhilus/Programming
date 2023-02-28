using System;
using System.Collections.Generic;

namespace DAL.Entities;

public partial class RegimeT
{
    public int Id { get; set; }

    public string Codigo { get; set; } = null!;

    public string Descricao { get; set; } = null!;

    public int IdEntidade { get; set; }

    public string? CgTpProdutoVang { get; set; }

    public bool? Activo { get; set; }

    public bool TemPotNeg { get; set; }

    public bool? GesEntrega { get; set; }

    public bool? GesRecolha { get; set; }

    public bool? ViaParser { get; set; }
}
