using System;
using System.Collections.Generic;

namespace GCOM2Users.Models;

public partial class ManifestoEstadosLog
{
    public int Id { get; set; }

    public int? IdManifesto { get; set; }

    public byte IdEntidade { get; set; }

    public DateTime? DtEstado { get; set; }

    public int? IdScanEstado { get; set; }

    public int? IdEstado { get; set; }
}
