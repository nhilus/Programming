using System;
using System.Collections.Generic;

namespace DAL.Entities;

public partial class FornecedorUtilizadoresTlog
{
    public int IdTrigger { get; set; }

    public DateTime DtTrigger { get; set; }

    public string Accao { get; set; } = null!;

    public int Id { get; set; }

    public int IdFornecedor { get; set; }

    public int IdUtil { get; set; }

    public bool Activo { get; set; }

    public int? IdUtilIntrod { get; set; }

    public DateTime? DtIntrod { get; set; }

    public int? IdUtilUltAct { get; set; }

    public DateTime? DtUltAct { get; set; }
}
