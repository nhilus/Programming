using System;
using System.Collections.Generic;

namespace GCOM2Users.Models;

public partial class AlteracoesServico
{
    public int? IdUnix { get; set; }

    public int? IdCliente { get; set; }

    public int? IdServicoOrigem { get; set; }

    public DateTime? DtFim { get; set; }

    public int? IdServicoDest { get; set; }

    public DateTime? DtIni { get; set; }

    public int? IdCliMorada { get; set; }

    public int? IdEntidade { get; set; }
}
