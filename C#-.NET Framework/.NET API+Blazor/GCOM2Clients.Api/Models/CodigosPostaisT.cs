using System;
using System.Collections.Generic;

namespace GCOM2Users.Models;

public partial class CodigosPostaisT
{
    public int Id { get; set; }

    public string? Cpostal { get; set; }

    public string Cp4 { get; set; } = null!;

    public string Cp3 { get; set; } = null!;

    public string Localidade { get; set; } = null!;

    public string? Cp7l { get; set; }

    public int? IdPais { get; set; }

    public DateTime? DtCriacao { get; set; }

    public int? IdUtilCriacao { get; set; }

    public DateTime? DtUltAlt { get; set; }

    public int? IdUtilUltAlt { get; set; }

    public bool? Activo { get; set; }

    public int? IdDistrito { get; set; }

    public int? IdIvareg { get; set; }
}
