using System;
using System.Collections.Generic;

namespace DAL.Entities;

public partial class PjManifesto
{
    public int? IdMaster { get; set; }

    public string? Awb { get; set; }

    public DateTime? DtEnvio { get; set; }

    public string? Nome { get; set; }

    public string? Empresa { get; set; }
}
