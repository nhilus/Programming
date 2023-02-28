using System;
using System.Collections.Generic;

namespace GCOM2Users.Models;

public partial class ManifestoDevolucao
{
    public int IdManifestoOrig { get; set; }

    public int IdManifestoDev { get; set; }

    public DateTime DtIntrod { get; set; }

    public short IdUtilIntrod { get; set; }

    public int? IdTipoDev { get; set; }
}
