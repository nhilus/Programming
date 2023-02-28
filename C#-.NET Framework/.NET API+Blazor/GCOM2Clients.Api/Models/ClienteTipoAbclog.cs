using System;
using System.Collections.Generic;

namespace GCOM2Users.Models;

public partial class ClienteTipoAbclog
{
    public int Id { get; set; }

    public int IdCliente { get; set; }

    public int IdEntidade { get; set; }

    public int IdTipoAbc { get; set; }

    public decimal ValorMedio { get; set; }

    public DateTime DtInicio { get; set; }

    public DateTime DtFim { get; set; }

    public DateTime DtIntrod { get; set; }
}
