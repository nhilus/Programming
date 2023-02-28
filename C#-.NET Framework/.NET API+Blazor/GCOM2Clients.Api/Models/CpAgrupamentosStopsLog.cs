using System;
using System.Collections.Generic;

namespace GCOM2Users.Models;

public partial class CpAgrupamentosStopsLog
{
    public int IdTrigger { get; set; }

    public int Id { get; set; }

    public int? IdStop { get; set; }

    public string? Morada { get; set; }

    public DateTime? DtIntrod { get; set; }

    public int? IdUtilIntrod { get; set; }

    public DateTime? DtUltAct { get; set; }

    public int? IdUtilUltAct { get; set; }

    public int? Activo { get; set; }
}
