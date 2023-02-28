using System;
using System.Collections.Generic;

namespace GCOM2Users.Models;

public partial class ClientesFacturaEmissaoT
{
    public int IdCliente { get; set; }

    public int IdClienteEmissao { get; set; }

    public int? IdCliMorada { get; set; }
}
