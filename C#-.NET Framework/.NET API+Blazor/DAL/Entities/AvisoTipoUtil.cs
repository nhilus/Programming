using System;
using System.Collections.Generic;

namespace DAL.Entities;

public partial class AvisoTipoUtil
{
    public int Id { get; set; }

    public int IdTipo { get; set; }

    public int IdUtil { get; set; }

    public bool? Activo { get; set; }
}
