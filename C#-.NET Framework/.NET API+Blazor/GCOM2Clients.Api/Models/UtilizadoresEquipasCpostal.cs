using System;
using System.Collections.Generic;

namespace GCOM2Users.Models;

public partial class UtilizadoresEquipasCpostal
{
    public int Id { get; set; }

    public int? IdCpostal { get; set; }

    public int? IdDinamicaComercial { get; set; }

    public int? IdEquipa { get; set; }

    public bool? Activo { get; set; }

    public DateTime? DtIntrod { get; set; }

    public int? IdUtilIntrod { get; set; }

    public DateTime? DtUltAct { get; set; }

    public int? IdUtilUltAct { get; set; }

    public int? IdEntidade { get; set; }
}
