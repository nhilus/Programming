using System;
using System.Collections.Generic;

namespace DAL.Entities;

public partial class ManifestoConsolidadosPlataformasEntidade
{
    public short IdManifestoConsolidadosPlataforma { get; set; }

    public byte IdEntidade { get; set; }

    public bool Orig { get; set; }

    public bool Dest { get; set; }

    public int? IdPlataforma { get; set; }

    public bool? Activo { get; set; }
}
