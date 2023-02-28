using System;
using System.Collections.Generic;

namespace DAL.Entities;

public partial class EntrevistaTipoAcesso
{
    public int Id { get; set; }

    public int IdEntrevistaTipo { get; set; }

    public int IdUtilizadorGrupo { get; set; }
}
