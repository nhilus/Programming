using System;
using System.Collections.Generic;

namespace DAL.Entities;

public partial class ManifestoConsolidadosTiposT
{
    public byte Id { get; set; }

    public string Codigo { get; set; } = null!;

    public string Descricao { get; set; } = null!;

    public byte IdRegime { get; set; }

    public bool? Activo { get; set; }

    public int? IdEntidade { get; set; }
}
