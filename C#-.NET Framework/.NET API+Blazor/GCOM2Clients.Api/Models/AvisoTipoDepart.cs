using System;
using System.Collections.Generic;

namespace GCOM2Users.Models;

public partial class AvisoTipoDepart
{
    public int Id { get; set; }

    public int IdTipo { get; set; }

    public int IdDepart { get; set; }

    public bool? Activo { get; set; }
}
