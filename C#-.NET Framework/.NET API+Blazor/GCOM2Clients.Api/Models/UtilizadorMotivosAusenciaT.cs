using System;
using System.Collections.Generic;

namespace GCOM2Users.Models;

public partial class UtilizadorMotivosAusenciaT
{
    public int Id { get; set; }

    public string Descricao { get; set; } = null!;

    public bool? Activo { get; set; }
}
