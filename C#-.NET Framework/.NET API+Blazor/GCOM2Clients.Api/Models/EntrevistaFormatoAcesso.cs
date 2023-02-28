using System;
using System.Collections.Generic;

namespace GCOM2Users.Models;

public partial class EntrevistaFormatoAcesso
{
    public int Id { get; set; }

    public int IdEntrevistaFormato { get; set; }

    public int IdUtilizadorGrupo { get; set; }
}
