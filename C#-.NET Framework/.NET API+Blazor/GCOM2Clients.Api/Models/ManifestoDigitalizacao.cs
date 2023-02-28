using System;
using System.Collections.Generic;

namespace GCOM2Users.Models;

public partial class ManifestoDigitalizacao
{
    public string Awb { get; set; } = null!;

    public int NumDocAdos { get; set; }

    public DateTime DtIntrod { get; set; }

    public int IdManifesto { get; set; }

    public int? IdTipoDigit { get; set; }
}
