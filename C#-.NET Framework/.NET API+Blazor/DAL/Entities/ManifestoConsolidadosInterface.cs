using System;
using System.Collections.Generic;

namespace DAL.Entities;

public partial class ManifestoConsolidadosInterface
{
    public int IdManifestoConsolidado { get; set; }

    public byte IdManifestoConsolidadoInterfaceTipo { get; set; }

    public DateTime? DtEnv { get; set; }
}
