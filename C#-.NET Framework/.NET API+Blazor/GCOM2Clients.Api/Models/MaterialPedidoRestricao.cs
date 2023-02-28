using System;
using System.Collections.Generic;

namespace GCOM2Users.Models;

public partial class MaterialPedidoRestricao
{
    public int Id { get; set; }

    public int IdCliente { get; set; }

    public int Restricao { get; set; }

    public int? Excepcao { get; set; }

    public DateTime? DtIntrod { get; set; }

    public int? IdUtilIntrod { get; set; }

    public int? IdUtilUltAct { get; set; }

    public DateTime? DtUltAct { get; set; }

    public bool? Activo { get; set; }
}
