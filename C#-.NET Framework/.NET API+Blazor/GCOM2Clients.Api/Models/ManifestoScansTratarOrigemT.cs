using System;
using System.Collections.Generic;

namespace GCOM2Users.Models;

public partial class ManifestoScansTratarOrigemT
{
    public byte Id { get; set; }

    public string Codigo { get; set; } = null!;

    public string Descricao { get; set; } = null!;

    public byte IdEntidade { get; set; }

    public byte IdRegime { get; set; }

    public bool? Activo { get; set; }
}
