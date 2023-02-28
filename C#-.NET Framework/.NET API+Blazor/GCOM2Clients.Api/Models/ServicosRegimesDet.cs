using System;
using System.Collections.Generic;

namespace GCOM2Users.Models;

public partial class ServicosRegimesDet
{
    public int Id { get; set; }

    public int IdServico { get; set; }

    public int IdRegime { get; set; }

    public int IdServicoDet { get; set; }

    public int IdTipoIva { get; set; }

    public bool? Activo { get; set; }

    public string? CodIva { get; set; }
}
