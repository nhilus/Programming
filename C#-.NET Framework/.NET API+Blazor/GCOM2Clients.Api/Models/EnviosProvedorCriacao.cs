using System;
using System.Collections.Generic;

namespace GCOM2Users.Models;

public partial class EnviosProvedorCriacao
{
    public int Id { get; set; }

    public int? IdProvedor { get; set; }

    public int? IdManifesto { get; set; }

    public DateTime? Dtintrod { get; set; }

    public int? IdUtilIntrod { get; set; }

    public DateTime? DtCriacaoProvedor { get; set; }

    public string? Msg { get; set; }

    public int? IdParserHeader { get; set; }

    public DateTime? DtUltAct { get; set; }
}
