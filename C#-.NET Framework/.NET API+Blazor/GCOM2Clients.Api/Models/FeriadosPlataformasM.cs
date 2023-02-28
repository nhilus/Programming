using System;
using System.Collections.Generic;

namespace GCOM2Users.Models;

public partial class FeriadosPlataformasM
{
    public int Id { get; set; }

    public int? IdFeriado { get; set; }

    public int? IdPlataforma { get; set; }

    public bool? Activo { get; set; }

    public int? IdUtilIntrod { get; set; }

    public DateTime? DtUtilIntrod { get; set; }

    public int? IdUtilUltAct { get; set; }

    public DateTime? DtUltAct { get; set; }
}
