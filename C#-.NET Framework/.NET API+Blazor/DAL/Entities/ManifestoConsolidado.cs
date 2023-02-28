using System;
using System.Collections.Generic;

namespace DAL.Entities;

public partial class ManifestoConsolidado
{
    public int Id { get; set; }

    public byte IdTipoCons { get; set; }

    public byte IdTipoEmbalagem { get; set; }

    public byte IdPltOrigem { get; set; }

    public byte IdPltDestino { get; set; }

    public byte IdEntidade { get; set; }

    public string Awb { get; set; } = null!;

    public int IdManifesto { get; set; }

    public DateTime DtIntrod { get; set; }

    public short IdUtilIntrod { get; set; }

    public DateTime DtInicio { get; set; }

    public short? IdUtilInicio { get; set; }

    public DateTime? DtFim { get; set; }

    public short? IdUtilFim { get; set; }

    public string? Obs { get; set; }
}
