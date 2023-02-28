using System;
using System.Collections.Generic;

namespace DAL.Entities;

public partial class AvisoTipoGrupo
{
    public int Id { get; set; }

    public int IdTipo { get; set; }

    public int IdGrupo { get; set; }

    public bool? Activo { get; set; }
}
