using System;
using System.Collections.Generic;

namespace GCOM2Users.Models;

public partial class PaisEstacoesT
{
    public int Id { get; set; }

    public int IdPais { get; set; }

    public string Estacao { get; set; } = null!;

    public bool? Activo { get; set; }

    public int? IdUtil { get; set; }

    public DateTime? DtIntrod { get; set; }

    public int? IdUtilUltAct { get; set; }

    public DateTime? DtUltAct { get; set; }
}
