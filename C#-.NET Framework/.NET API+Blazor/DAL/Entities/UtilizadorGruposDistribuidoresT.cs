using System;
using System.Collections.Generic;

namespace DAL.Entities;

public partial class UtilizadorGruposDistribuidoresT
{
    public int Id { get; set; }

    public int IdGrupo { get; set; }

    public int IdEntidadeGrupo { get; set; }

    public int IdDistribuidor { get; set; }
}
