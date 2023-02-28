using System;
using System.Collections.Generic;

namespace GCOM2Users.Models;

public partial class ManifestoSeguranca
{
    public int IdManifesto { get; set; }

    public DateTime DtIntrod { get; set; }

    public int IdUtilIntrod { get; set; }

    public bool Concluido { get; set; }
}
