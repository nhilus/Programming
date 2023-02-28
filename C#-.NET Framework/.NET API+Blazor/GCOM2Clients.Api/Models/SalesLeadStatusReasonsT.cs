using System;
using System.Collections.Generic;

namespace GCOM2Users.Models;

public partial class SalesLeadStatusReasonsT
{
    public byte Id { get; set; }

    public string? Codigo { get; set; }

    public string Descricao { get; set; } = null!;

    public int IdLeadStatus { get; set; }

    public bool? Manual { get; set; }

    public int IdUtilIntrod { get; set; }

    public DateTime DtIntrod { get; set; }

    public int IdUtilUltAct { get; set; }

    public DateTime DtUltAct { get; set; }

    public bool? Activo { get; set; }

    public bool? Fecha { get; set; }
}
