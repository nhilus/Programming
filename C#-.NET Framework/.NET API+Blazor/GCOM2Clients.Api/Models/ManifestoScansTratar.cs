using System;
using System.Collections.Generic;

namespace GCOM2Users.Models;

public partial class ManifestoScansTratar
{
    public int IdScan { get; set; }

    public byte IdOrigem { get; set; }

    public int IdManifesto { get; set; }

    public byte IdEntidade { get; set; }

    public byte IdTrataDept { get; set; }

    public DateTime DtIntrod { get; set; }

    public byte? IdTipoTrata { get; set; }

    public string? IdScanTrata { get; set; }

    public DateTime? DtTrata { get; set; }

    public short? IdUtilTrata { get; set; }

    public string? ObsTrata { get; set; }

    public bool IsTratado { get; set; }

    public int? IdScanMaster { get; set; }

    public string? CtcTrata { get; set; }

    public string? TelfTrata { get; set; }

    public string? EmailTrata { get; set; }

    public string? MoradaTrata { get; set; }

    public string? CPostalTrata { get; set; }

    public int? IdCpostalTrata { get; set; }

    public string? LocalidadeTrata { get; set; }

    public string? PaisTrata { get; set; }

    public int? IdPaisTrata { get; set; }

    public DateTime? DtAplicarTratamento { get; set; }
}
