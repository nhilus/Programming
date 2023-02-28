using System;
using System.Collections.Generic;

namespace DAL.Entities;

public partial class EnvioPodsLog
{
    public int? IdCliente { get; set; }

    public int? IdImportacaoManifesto { get; set; }

    public string? AwbNumber { get; set; }

    public DateTime? DtEnvio { get; set; }

    public int? IdCliMorada { get; set; }

    public int? IdEntidade { get; set; }
}
