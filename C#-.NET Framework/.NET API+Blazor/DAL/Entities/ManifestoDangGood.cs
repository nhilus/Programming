using System;
using System.Collections.Generic;

namespace DAL.Entities;

public partial class ManifestoDangGood
{
    public int IdManifesto { get; set; }

    public string Awb { get; set; } = null!;

    public int? IdTipoDangGoods { get; set; }

    public bool? NotifFedex { get; set; }

    public bool? CasosNovos { get; set; }

    public bool? Fact { get; set; }
}
