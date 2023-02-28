using System;
using System.Collections.Generic;

namespace DAL.Entities;

public partial class ManifestoRecolhaPrevistum
{
    public int IdManifesto { get; set; }

    public int IdPickup { get; set; }

    public int? IdUtilIntrod { get; set; }

    public DateTime? DtIntrod { get; set; }
}
