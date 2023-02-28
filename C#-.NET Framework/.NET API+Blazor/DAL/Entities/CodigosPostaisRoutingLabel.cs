using System;
using System.Collections.Generic;

namespace DAL.Entities;

public partial class CodigosPostaisRoutingLabel
{
    public int IdCpostal { get; set; }

    public string? RoutingCode { get; set; }

    public string? NoonCode { get; set; }

    public DateTime? DtIntrod { get; set; }

    public DateTime? DtUltAct { get; set; }

    public int? IdUtilIntrod { get; set; }

    public int? IdUtilUltAct { get; set; }
}
