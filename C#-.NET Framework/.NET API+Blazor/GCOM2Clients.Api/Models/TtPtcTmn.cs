using System;
using System.Collections.Generic;

namespace GCOM2Users.Models;

public partial class TtPtcTmn
{
    public int Id { get; set; }

    public string Estado { get; set; } = null!;

    public int? IdCausa { get; set; }

    public string? Descricao { get; set; }

    public string? ScanCode { get; set; }

    public bool? Finaliza { get; set; }
}
