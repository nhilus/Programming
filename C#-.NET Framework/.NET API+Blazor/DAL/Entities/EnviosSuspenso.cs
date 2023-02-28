using System;
using System.Collections.Generic;

namespace DAL.Entities;

public partial class EnviosSuspenso
{
    public int IdManifesto { get; set; }

    public DateTime? DtIntrod { get; set; }

    public int? IdUtilIntrod { get; set; }

    public DateTime? DtultAct { get; set; }

    public int? IdUtilUltAct { get; set; }

    public int? Activo { get; set; }

    public bool? SemExpedidor { get; set; }

    public bool? Loginv { get; set; }

    public DateTime? DtLogProcessado { get; set; }
}
