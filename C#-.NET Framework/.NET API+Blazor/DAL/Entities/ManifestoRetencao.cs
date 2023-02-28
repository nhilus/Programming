using System;
using System.Collections.Generic;

namespace DAL.Entities;

public partial class ManifestoRetencao
{
    public int IdManifesto { get; set; }

    public string Awb { get; set; } = null!;

    public byte IdEntidade { get; set; }

    public bool ReterEnvio { get; set; }

    public DateTime? DtReterAte { get; set; }

    public string? ObsReterEnvio { get; set; }

    public short IdUtilReterEnvio { get; set; }

    public DateTime DtReterEnvio { get; set; }

    public short? IdUtilFimReter { get; set; }

    public DateTime? DtFimReter { get; set; }
}
