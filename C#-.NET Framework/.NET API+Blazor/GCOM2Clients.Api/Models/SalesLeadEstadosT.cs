using System;
using System.Collections.Generic;

namespace GCOM2Users.Models;

public partial class SalesLeadEstadosT
{
    public int Id { get; set; }

    public int IdEntidade { get; set; }

    public string Codigo { get; set; } = null!;

    public string Descricao { get; set; } = null!;

    public bool IsDefault { get; set; }

    public bool IsAuto { get; set; }

    public bool? IsManual { get; set; }

    public bool IsSalesLeadValido { get; set; }

    public bool? Pendente { get; set; }

    public byte IdTipoOrigem { get; set; }
}
