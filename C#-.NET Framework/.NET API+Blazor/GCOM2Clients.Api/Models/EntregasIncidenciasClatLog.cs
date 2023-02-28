using System;
using System.Collections.Generic;

namespace GCOM2Users.Models;

public partial class EntregasIncidenciasClatLog
{
    public int? IdCliente { get; set; }

    public string? RefCliente { get; set; }

    public string? AwbNumber { get; set; }

    public DateTime? ScanDate { get; set; }

    public string? Estado { get; set; }

    public string? Destinatario { get; set; }

    public DateTime? DtEnvio { get; set; }

    public int? IdScan { get; set; }

    public int? IdCausa { get; set; }

    public int? IdCliMorada { get; set; }

    public int? IdEntidade { get; set; }
}
