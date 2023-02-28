using System;
using System.Collections.Generic;

namespace GCOM2Users.Models;

public partial class IncidenciasRtmsMap
{
    public int IdCliente { get; set; }

    public int IdEntidade { get; set; }

    public string ScanCode { get; set; } = null!;

    public string? CodCliente { get; set; }

    public string? DescIncid { get; set; }

    public string? DescTipoIncid { get; set; }

    public int? IdCliMorada { get; set; }
}
