using System;
using System.Collections.Generic;

namespace GCOM2Users.Models;

public partial class LineHaulPlataformasTemplate
{
    public int Id { get; set; }

    public int IdTemplate { get; set; }

    public int IdPlataforma { get; set; }

    public DateTime? HoraPartida { get; set; }

    public DateTime? HoraChegada { get; set; }

    public bool? PltFinal { get; set; }

    public int? IdUtilIntrod { get; set; }

    public DateTime? DtIntrod { get; set; }

    public int? IdUtilUltAct { get; set; }

    public DateTime? DtUltAct { get; set; }

    public int? Ordem { get; set; }
}
