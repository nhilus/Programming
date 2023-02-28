using System;
using System.Collections.Generic;

namespace GCOM2Users.Models;

public partial class PjManifestos2
{
    public int? IdMaster { get; set; }

    public string? Awb { get; set; }

    public DateTime? DtEnvio { get; set; }

    public string? Nome { get; set; }

    public string? Empresa { get; set; }
}
