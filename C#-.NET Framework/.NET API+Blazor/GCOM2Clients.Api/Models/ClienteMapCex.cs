using System;
using System.Collections.Generic;

namespace GCOM2Users.Models;

public partial class ClienteMapCex
{
    public int IdCliente { get; set; }

    public string IdExterno { get; set; } = null!;

    public DateTime DtInsercao { get; set; }

    public int? CodGcom { get; set; }
}
