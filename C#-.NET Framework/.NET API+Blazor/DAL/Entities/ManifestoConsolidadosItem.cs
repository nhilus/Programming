using System;
using System.Collections.Generic;

namespace DAL.Entities;

public partial class ManifestoConsolidadosItem
{
    public int Id { get; set; }

    public int IdManifestoConsolidado { get; set; }

    public string Awb { get; set; } = null!;

    public byte IdEntidade { get; set; }

    public int IdManifesto { get; set; }

    public DateTime DtIntrod { get; set; }

    public short IdUtilIntrod { get; set; }

    public DateTime DtInicio { get; set; }

    public short? IdUtilInicio { get; set; }

    public DateTime? DtFim { get; set; }

    public short? IdUtilFim { get; set; }
}
