using System;
using System.Collections.Generic;

namespace GCOM2Users.Models;

public partial class BackOfficeTiposEstadoT
{
    public int Id { get; set; }

    public string Descricao { get; set; } = null!;

    public bool? Fecha { get; set; }
}
