using System;
using System.Collections.Generic;

namespace GCOM2Users.Models;

public partial class MoedaT
{
    public int Id { get; set; }

    public string Sigla { get; set; } = null!;

    public string SiglaFedex { get; set; } = null!;

    public bool? Activo { get; set; }
}
