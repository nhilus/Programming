using System;
using System.Collections.Generic;

namespace GCOM2Users.Models;

public partial class RotasEntidadesM
{
    public int Id { get; set; }

    public int IdRota { get; set; }

    public int IdEntidade { get; set; }

    public bool? Activo { get; set; }

    public int? IdUtilUltAct { get; set; }

    public DateTime? DtUltAct { get; set; }
}
