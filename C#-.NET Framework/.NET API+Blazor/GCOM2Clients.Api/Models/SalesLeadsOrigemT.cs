using System;
using System.Collections.Generic;

namespace GCOM2Users.Models;

public partial class SalesLeadsOrigemT
{
    public byte Id { get; set; }

    public string Descricao { get; set; } = null!;

    public string Grupo { get; set; } = null!;

    public decimal OnTime { get; set; }

    public decimal ToleranceTime { get; set; }

    public decimal OffTime { get; set; }

    public int IdUtilIntrod { get; set; }

    public DateTime DtIntrod { get; set; }

    public int IdUtilUltAct { get; set; }

    public DateTime DtUltAct { get; set; }

    public bool? Activo { get; set; }
}
