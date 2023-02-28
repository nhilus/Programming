using System;
using System.Collections.Generic;

namespace GCOM2Users.Models;

public partial class MenuUrlreportsUtilizadore
{
    public int Id { get; set; }

    public int IdMenuReport { get; set; }

    public int IdUtilizador { get; set; }

    public bool TodosClientes { get; set; }

    public bool TodosUtilizadores { get; set; }

    public bool? TodasPlataformas { get; set; }

    public bool? Visivel { get; set; }

    public bool? Activo { get; set; }

    public DateTime DtIntrod { get; set; }

    public int? IdUtilIntrod { get; set; }

    public DateTime DtUltAct { get; set; }

    public int? IdUtilUltAct { get; set; }
}
