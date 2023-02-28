using System;
using System.Collections.Generic;

namespace GCOM2Users.Models;

public partial class ParserReferenciasTipo
{
    public int Id { get; set; }

    public string Codigo { get; set; } = null!;

    public int? IdManifestoReferenciasTipoT { get; set; }
}
