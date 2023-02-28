using System;
using System.Collections.Generic;

namespace GCOM2Users.Models;

public partial class ManifestoUltScan
{
    public int IdManifesto { get; set; }

    public string Awb { get; set; } = null!;

    public byte IdEntidade { get; set; }

    public bool Concluido { get; set; }

    public int? IdUltScan { get; set; }

    public int? IdUltScanSd { get; set; }

    public byte? IdRegime { get; set; }

    public byte? IdDistribuidor { get; set; }

    public bool Anulado { get; set; }

    public int? IdUltScanOpDistr { get; set; }

    public byte? IdEstadoManifesto { get; set; }
}
