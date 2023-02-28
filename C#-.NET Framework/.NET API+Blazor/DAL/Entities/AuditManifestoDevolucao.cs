using System;
using System.Collections.Generic;

namespace DAL.Entities;

public partial class AuditManifestoDevolucao
{
    public int IdAudit { get; set; }

    public string Type { get; set; } = null!;

    public int IdManifestoOrig { get; set; }

    public int IdManifestoDev { get; set; }

    public DateTime DtIntrod { get; set; }

    public short IdUtilIntrod { get; set; }

    public bool AuditLog { get; set; }

    public bool AuditFact { get; set; }

    public bool AuditPortal { get; set; }

    public int? IdTipoDev { get; set; }
}
