using System;
using System.Collections.Generic;

namespace GCOM2Users.Models;

public partial class ManifestoImpressao
{
    public int IdManifesto { get; set; }

    public byte IdTipoImpressao { get; set; }

    public string Awb { get; set; } = null!;

    public byte IdEntidade { get; set; }

    public DateTime Data { get; set; }

    public short IdUtil { get; set; }
}
