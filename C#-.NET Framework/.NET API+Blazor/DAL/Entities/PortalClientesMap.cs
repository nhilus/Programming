using System;
using System.Collections.Generic;

namespace DAL.Entities;

public partial class PortalClientesMap
{
    public int IdCliente { get; set; }

    public int IdClientePortal { get; set; }

    public int? IdCliMorada { get; set; }

    public int? IdEntidade { get; set; }
}
