using System;
using System.Collections.Generic;

namespace GCOM2Users.Models;

public partial class RotasCodPostaisRecolha
{
    public int IdRota { get; set; }

    public int IdCp { get; set; }

    public DateTime? Req { get; set; }

    public DateTime? CutOff1 { get; set; }

    public DateTime? CutOff2 { get; set; }

    public int? DiasIb { get; set; }

    public int IdEntidade { get; set; }

    public int? IdUtilIntrod { get; set; }

    public DateTime? DtIntrod { get; set; }

    public int? IdUtilUltAct { get; set; }

    public DateTime? DtUltAct { get; set; }
}
