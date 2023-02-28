using System;
using System.Collections.Generic;

namespace DAL.Entities;

public partial class RecolhasProvedorCriacao
{
    public int Id { get; set; }

    public int? IdProvedor { get; set; }

    public int? IdRecolha { get; set; }

    public DateTime? DtIntrod { get; set; }

    public int? IdUtilIntrod { get; set; }

    public DateTime? DtCriacaoProvedor { get; set; }

    public string? Msg { get; set; }

    public string? IdRecolhaParceiro { get; set; }

    public bool? Concluida { get; set; }

    public DateTime? DtConclusao { get; set; }

    public string? Provedor { get; set; }

    public DateTime? DtUltAct { get; set; }
}
