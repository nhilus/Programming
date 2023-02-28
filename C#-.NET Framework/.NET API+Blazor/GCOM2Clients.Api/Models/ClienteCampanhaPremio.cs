using System;
using System.Collections.Generic;

namespace GCOM2Users.Models;

public partial class ClienteCampanhaPremio
{
    public int Id { get; set; }

    public int? IdCampanha { get; set; }

    public int? IdEntidade { get; set; }

    public string? Codigo { get; set; }

    public string? Descricao { get; set; }

    public decimal? Pontos { get; set; }

    public int? IdUtilIntrod { get; set; }

    public DateTime? DtIntrod { get; set; }

    public int? IdUtilUltAct { get; set; }

    public DateTime? DtUltAct { get; set; }
}
