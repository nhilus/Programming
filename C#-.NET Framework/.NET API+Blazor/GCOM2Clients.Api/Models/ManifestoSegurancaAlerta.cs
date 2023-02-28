using System;
using System.Collections.Generic;

namespace GCOM2Users.Models;

public partial class ManifestoSegurancaAlerta
{
    public int Id { get; set; }

    public int IdManifesto { get; set; }

    public int IdTipoAlerta { get; set; }

    public DateTime DtIntrod { get; set; }

    public int? IdScanIntrod { get; set; }

    public int? IdPlataforma { get; set; }

    public int? IdRota { get; set; }

    public DateTime? DtFecho { get; set; }

    public int? IdScanFecho { get; set; }
}
