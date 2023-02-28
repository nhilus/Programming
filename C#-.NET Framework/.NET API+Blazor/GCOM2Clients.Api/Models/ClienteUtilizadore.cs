using System;
using System.Collections.Generic;

namespace GCOM2Users.Models;

public partial class ClienteUtilizadore
{
    public int Id { get; set; }

    public int IdCliente { get; set; }

    public int IdUtil { get; set; }

    public int IdTipoUtil { get; set; }

    public bool Resp { get; set; }

    public int IdEntidade { get; set; }

    public DateTime? DtIntrod { get; set; }

    public int? IdUtilIntrod { get; set; }

    public int? IdUtilUltAct { get; set; }

    public DateTime? DtUltAct { get; set; }

    public int? IdCliMorada { get; set; }

    public bool? IsAe { get; set; }
}
