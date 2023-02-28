using System;
using System.Collections.Generic;

namespace GCOM2Users.Models;

public partial class ClientesAlteracoesSap
{
    public int Id { get; set; }

    public int IdCliente { get; set; }

    public DateTime DtAlt { get; set; }

    public string? IdUtilAlt { get; set; }

    public bool? ExpToSap { get; set; }

    public DateTime? DtexpToSap { get; set; }

    public int? IdCliMorada { get; set; }
}
