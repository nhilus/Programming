using System;
using System.Collections.Generic;

namespace GCOM2Users.Models;

public partial class ClienteEmailingCliente
{
    public int? Id { get; set; }

    public int? IdCliente { get; set; }

    public int? IdCliMorada { get; set; }

    public int? IdTipoemailing { get; set; }

    public bool? Activo { get; set; }
}
