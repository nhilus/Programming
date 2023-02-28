using System;
using System.Collections.Generic;

namespace GCOM2Users.Models;

public partial class ManifestoInterface
{
    public int IdManifesto { get; set; }

    public int IdInterface { get; set; }

    public bool Env { get; set; }

    public DateTime? DtEnv { get; set; }

    public string? Accao { get; set; }

    public DateTime? DtUltAct { get; set; }

    public DateTime? DtIntrod { get; set; }
}
