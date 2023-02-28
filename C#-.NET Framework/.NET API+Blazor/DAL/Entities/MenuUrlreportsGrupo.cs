using System;
using System.Collections.Generic;

namespace DAL.Entities;

public partial class MenuUrlreportsGrupo
{
    public int Id { get; set; }

    public int IdMenuReport { get; set; }

    public int IdGrupo { get; set; }

    public int IdEntidade { get; set; }

    public bool TodosClientes { get; set; }

    public bool TodosUtilizadores { get; set; }

    public bool? TodasPlataformas { get; set; }

    public bool? Visivel { get; set; }

    public bool? Activo { get; set; }
}
