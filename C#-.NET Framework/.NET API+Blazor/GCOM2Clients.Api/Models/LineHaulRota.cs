using System;
using System.Collections.Generic;

namespace GCOM2Users.Models;

public partial class LineHaulRota
{
    public int? Id { get; set; }

    public string? Rota { get; set; }

    public string? Descricao { get; set; }

    public decimal? Custo { get; set; }

    public DateTime? HoraPrevistaPartida { get; set; }

    public DateTime? HoraPrevistaChegada { get; set; }

    public int? IdEntidade { get; set; }

    public bool? Activo { get; set; }

    public int? IdUtilIntrod { get; set; }

    public DateTime? DtIntrod { get; set; }

    public int? IdUtilUltAct { get; set; }

    public DateTime? DtUltAct { get; set; }
}
