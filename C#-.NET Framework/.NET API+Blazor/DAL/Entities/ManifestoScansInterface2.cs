using System;
using System.Collections.Generic;

namespace DAL.Entities;

public partial class ManifestoScansInterface2
{
    public int IdManifestoScan { get; set; }

    public byte IdManifestoScanInterfaceTipo { get; set; }

    public DateTime? DtEnv { get; set; }
}
