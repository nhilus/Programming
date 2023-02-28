using System;
using System.Collections.Generic;

namespace DAL.Entities;

public partial class ClienteMapCex
{
    public int IdCliente { get; set; }

    public string IdExterno { get; set; } = null!;

    public DateTime DtInsercao { get; set; }

    public int? CodGcom { get; set; }
}
