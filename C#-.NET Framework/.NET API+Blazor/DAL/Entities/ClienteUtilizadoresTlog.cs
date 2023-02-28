using System;
using System.Collections.Generic;

namespace DAL.Entities;

public partial class ClienteUtilizadoresTlog
{
    public int IdTrigger { get; set; }

    public DateTime DtTrigger { get; set; }

    public int Id { get; set; }

    public int IdCliente { get; set; }

    public int IdUtil { get; set; }

    public int IdTipoUtil { get; set; }

    public bool Resp { get; set; }

    public int IdEntidade { get; set; }

    public int IdUtilUltAct { get; set; }

    public DateTime DtUltAct { get; set; }

    public int? IdCliMorada { get; set; }
}
