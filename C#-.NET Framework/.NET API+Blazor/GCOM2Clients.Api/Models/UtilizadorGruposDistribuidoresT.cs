using System;
using System.Collections.Generic;

namespace GCOM2Users.Models;

public partial class UtilizadorGruposDistribuidoresT
{
    public int Id { get; set; }

    public int IdGrupo { get; set; }

    public int IdEntidadeGrupo { get; set; }

    public int IdDistribuidor { get; set; }
}
