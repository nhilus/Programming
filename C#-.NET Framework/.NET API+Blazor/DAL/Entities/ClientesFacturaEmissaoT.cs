using System;
using System.Collections.Generic;

namespace DAL.Entities;

public partial class ClientesFacturaEmissaoT
{
    public int IdCliente { get; set; }

    public int IdClienteEmissao { get; set; }

    public int? IdCliMorada { get; set; }
}
