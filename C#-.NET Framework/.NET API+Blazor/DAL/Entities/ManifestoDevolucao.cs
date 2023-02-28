using System;
using System.Collections.Generic;

namespace DAL.Entities;

public partial class ManifestoDevolucao
{
    public int IdManifestoOrig { get; set; }

    public int IdManifestoDev { get; set; }

    public DateTime DtIntrod { get; set; }

    public short IdUtilIntrod { get; set; }

    public int? IdTipoDev { get; set; }
}
