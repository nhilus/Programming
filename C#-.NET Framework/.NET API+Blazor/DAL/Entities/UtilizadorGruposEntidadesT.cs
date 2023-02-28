using System;
using System.Collections.Generic;

namespace DAL.Entities;

public partial class UtilizadorGruposEntidadesT
{
    public int Id { get; set; }

    public int IdGrupo { get; set; }

    public int IdEntidadeGrupo { get; set; }

    public int IdEntidade { get; set; }
}
