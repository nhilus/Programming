using System;
using System.Collections.Generic;

namespace DAL.Entities;

public partial class ManifestoConsolidadosEmbalagemTiposT
{
    public byte Id { get; set; }

    public string Codigo { get; set; } = null!;

    public string Descricao { get; set; } = null!;

    public byte IdEntidade { get; set; }

    public bool? Activo { get; set; }

    public string? CodGrasp { get; set; }
}
