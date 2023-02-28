using System;
using System.Collections.Generic;

namespace GCOM2Users.Models;

public partial class ManifestoReferencia
{
    public int IdManifesto { get; set; }

    public int IdManifRefTipo { get; set; }

    public string? Referencia { get; set; }

    public int? IdEntidade { get; set; }

    public DateTime? DtIntrod { get; set; }

    public DateTime? DtUltAct { get; set; }
}
