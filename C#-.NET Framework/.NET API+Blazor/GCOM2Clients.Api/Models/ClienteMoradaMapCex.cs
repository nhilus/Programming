using System;
using System.Collections.Generic;

namespace GCOM2Users.Models;

public partial class ClienteMoradaMapCex
{
    public int Id { get; set; }

    public int IdCliMorada { get; set; }

    public int? IdEntidade { get; set; }

    public int? IdClienteGcom { get; set; }

    public string IdExterno { get; set; } = null!;

    public DateTime DtInsercao { get; set; }
}
