using System;
using System.Collections.Generic;

namespace GCOM2Users.Models;

public partial class RealocarRecolhasRota
{
    public int Id { get; set; }

    public DateTime? DtInicio { get; set; }

    public DateTime? DtFim { get; set; }

    public int? IdRota1 { get; set; }

    public string? Rota1 { get; set; }

    public int? IdRota2 { get; set; }

    public string? Rota2 { get; set; }

    public int? Activo { get; set; }

    public int? IdUtilIntrod { get; set; }

    public DateTime? DtIntrod { get; set; }

    public int? IdUtilUltAct { get; set; }

    public DateTime? DtUltAct { get; set; }
}
