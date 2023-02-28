using System;
using System.Collections.Generic;

namespace GCOM2Users.Models;

public partial class PickupCustosManuai
{
    public int Id { get; set; }

    public int? IdPickupCustoReal { get; set; }

    public int? IdServicoDet { get; set; }

    public string? Obs { get; set; }

    public decimal? Valor { get; set; }

    public bool? Activo { get; set; }

    public int? IdUtilIntrod { get; set; }

    public DateTime? DtIntrod { get; set; }

    public int? IdUtilUltAct { get; set; }

    public DateTime? DtUltAct { get; set; }
}
