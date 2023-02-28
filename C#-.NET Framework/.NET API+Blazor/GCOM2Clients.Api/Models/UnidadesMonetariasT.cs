using System;
using System.Collections.Generic;

namespace GCOM2Users.Models;

public partial class UnidadesMonetariasT
{
    public int Id { get; set; }

    public string Sigla { get; set; } = null!;

    public string SiglaFedex { get; set; } = null!;

    public string? Descricao { get; set; }

    public decimal? Cambio { get; set; }

    public bool Default { get; set; }

    public bool? Activo { get; set; }

    public string? Iso { get; set; }
}
