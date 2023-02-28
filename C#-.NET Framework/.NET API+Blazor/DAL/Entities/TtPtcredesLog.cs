using System;
using System.Collections.Generic;

namespace DAL.Entities;

public partial class TtPtcredesLog
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

    public string? Signature { get; set; }

    public int Id { get; set; }

    public int? IdCliMorada { get; set; }

    public int? IdEntidade { get; set; }
}
