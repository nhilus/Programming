using System;
using System.Collections.Generic;

namespace DAL.Entities;

public partial class ClienteEmailingCliente
{
    public int? Id { get; set; }

    public int? IdCliente { get; set; }

    public int? IdCliMorada { get; set; }

    public int? IdTipoemailing { get; set; }

    public bool? Activo { get; set; }
}
