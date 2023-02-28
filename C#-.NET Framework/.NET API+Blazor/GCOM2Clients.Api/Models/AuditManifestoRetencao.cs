using System;
using System.Collections.Generic;

namespace GCOM2Users.Models;

public partial class AuditManifestoRetencao
{
    public int IdAudit { get; set; }

    public string Type { get; set; } = null!;

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

    public bool AuditLog { get; set; }

    public bool AuditFact { get; set; }

    public bool AuditPortal { get; set; }
}
