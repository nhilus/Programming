using System;
using System.Collections.Generic;

namespace GCOM2Users.Models;

public partial class UnidadesMonetariasCambioLog
{
    public int Id { get; set; }

    public int IdUnidMon { get; set; }

    public double CambioVend { get; set; }

    public double CambioComp { get; set; }

    public DateTime Data { get; set; }

    public int IdUtil { get; set; }

    public DateTime DtIntrod { get; set; }

    public int? IdUnidMonDest { get; set; }

    public double? CambioVendDest { get; set; }

    public double? CambioCompDest { get; set; }

    public int? Activo { get; set; }
}
