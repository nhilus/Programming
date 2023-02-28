using System;
using System.Collections.Generic;

namespace GCOM2Users.Models;

public partial class UtilizadorLoginLog
{
    public int Id { get; set; }

    public int IdUtil { get; set; }

    public DateTime DtLogin { get; set; }

    public string Ip { get; set; } = null!;

    public byte? Mobile { get; set; }

    public string? LoginAs { get; set; }

    public bool Sucesso { get; set; }

    public string? ChSessao { get; set; }

    public DateTime? DtLogoff { get; set; }

    public bool? ForcedLogoff { get; set; }

    public int? IdMirror { get; set; }

    public int? IdInterface { get; set; }
}
