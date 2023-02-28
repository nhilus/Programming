using System;
using System.Collections.Generic;

namespace GCOM2Users.Models;

public partial class ManifestoAssinatura
{
    public int Id { get; set; }

    public int? IdCliente { get; set; }

    public DateTime? Data { get; set; }

    public int? IdUtil { get; set; }

    public string? Nome { get; set; }

    public bool EnvInterface { get; set; }

    public DateTime? DtEnvInterface { get; set; }

    public int? IdCliMorada { get; set; }

    public int? IdImportacaoManifesto { get; set; }
}
