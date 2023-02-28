using System;
using System.Collections.Generic;

namespace GCOM2Users.Models;

public partial class PlataformaCliente
{
    public int IdPlataforma { get; set; }

    public int IdCliente { get; set; }

    public int IdEntidade { get; set; }

    public string CodCliente { get; set; } = null!;

    public int? IdCpostalInicio { get; set; }

    public int? IdCpostalFim { get; set; }

    public int? IdCliMorada { get; set; }
}
