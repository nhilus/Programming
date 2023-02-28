using System;
using System.Collections.Generic;

namespace DAL.Entities;

public partial class RotasCodPostaisEntrega
{
    public int IdRota { get; set; }

    public int IdCp { get; set; }

    public DateTime? CutOff1 { get; set; }

    public DateTime? CutOff2 { get; set; }

    public int? DiasOb { get; set; }

    public int IdEntidade { get; set; }

    public int? IdUtilIntrod { get; set; }

    public DateTime? DtIntrod { get; set; }

    public int? IdUtilUltAct { get; set; }

    public DateTime? DtUltAct { get; set; }
}
