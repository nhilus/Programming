using System;
using System.Collections.Generic;

namespace DAL.Entities;

public partial class ZonasRota
{
    public int Id { get; set; }

    public string Codigo { get; set; } = null!;

    public string Descricao { get; set; } = null!;

    public int IdUtilIntrod { get; set; }

    public DateTime DtIntrod { get; set; }

    public int IdUtilUltAct { get; set; }

    public DateTime DtUltAct { get; set; }

    public int? IdPais { get; set; }

    public int? Activo { get; set; }
}
