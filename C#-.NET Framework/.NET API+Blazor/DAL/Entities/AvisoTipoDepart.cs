using System;
using System.Collections.Generic;

namespace DAL.Entities;

public partial class AvisoTipoDepart
{
    public int Id { get; set; }

    public int IdTipo { get; set; }

    public int IdDepart { get; set; }

    public bool? Activo { get; set; }
}
