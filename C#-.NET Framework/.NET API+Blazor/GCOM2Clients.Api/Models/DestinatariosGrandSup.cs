using System;
using System.Collections.Generic;

namespace GCOM2Users.Models;

public partial class DestinatariosGrandSup
{
    public int Id { get; set; }

    public string? Morada { get; set; }

    public int? CsMorada { get; set; }

    public int? IdUtilIntrod { get; set; }

    public DateTime? DtIntrod { get; set; }

    public int? IdUtilUltAct { get; set; }

    public DateTime? DtUltAct { get; set; }

    public bool? Activo { get; set; }
}
