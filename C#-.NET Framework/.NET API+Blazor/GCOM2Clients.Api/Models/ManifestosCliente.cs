using System;
using System.Collections.Generic;

namespace GCOM2Users.Models;

public partial class ManifestosCliente
{
    public int? IdManifesto { get; set; }

    public string? AwbNumber { get; set; }

    public int? IdCliente { get; set; }

    public int? UtilIntrod { get; set; }

    public DateTime? DtIntrod { get; set; }

    public int? IdEntidade { get; set; }

    public DateTime? DtEnvio { get; set; }

    public int? IdCliMorada { get; set; }

    public int? IdExportacao { get; set; }
}
