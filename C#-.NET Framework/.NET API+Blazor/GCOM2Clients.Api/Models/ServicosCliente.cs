using System;
using System.Collections.Generic;

namespace GCOM2Users.Models;

public partial class ServicosCliente
{
    public int Id { get; set; }

    public int IdServico { get; set; }

    public int? IdCliente { get; set; }

    public int? IdCliMorada { get; set; }
}
