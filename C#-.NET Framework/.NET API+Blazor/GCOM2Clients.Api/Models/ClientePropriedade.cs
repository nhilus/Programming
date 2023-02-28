using System;
using System.Collections.Generic;

namespace GCOM2Users.Models;

public partial class ClientePropriedade
{
    public int Id { get; set; }

    public int IdCliente { get; set; }

    public int IdPropriedade { get; set; }

    public object? Valor { get; set; }

    public DateTime? DtIntrod { get; set; }

    public int? IdUtilIntrod { get; set; }

    public int IdCliMorada { get; set; }

    public int? IdEntidade { get; set; }
}
