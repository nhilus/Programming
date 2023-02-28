using System;
using System.Collections.Generic;

namespace GCOM2Users.Models;

public partial class ManifestoRecolha
{
    public int IdManifesto { get; set; }

    public int IdPickup { get; set; }

    public int? IdUtilIntrod { get; set; }

    public DateTime? DtIntrod { get; set; }
}
