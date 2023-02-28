using System;
using System.Collections.Generic;

namespace GCOM2Users.Models;

public partial class Provedore
{
    public int Id { get; set; }

    public string? Codigo { get; set; }

    public int? IdCliente { get; set; }

    public int? IdCliMorada { get; set; }

    public string? Nome { get; set; }

    public bool? Activo { get; set; }
}
