using System;
using System.Collections.Generic;

namespace GCOM2Users.Models;

public partial class LineHaulPlataforma
{
    public int Id { get; set; }

    public int IdLh { get; set; }

    public int IdPlataforma { get; set; }

    public DateTime? HoraPartida { get; set; }

    public DateTime? HoraChegada { get; set; }

    public DateTime? HoraRealPartida { get; set; }

    public DateTime? HoraRealChegada { get; set; }

    public bool? PltFinal { get; set; }

    public string? TxOcupacao { get; set; }

    public int? IdUtilIntrod { get; set; }

    public DateTime? DtIntrod { get; set; }

    public int? IdUtilUltAct { get; set; }

    public DateTime? DtUltAct { get; set; }

    public int? IdAeroporto { get; set; }

    public int? IdCompanhiaAerea { get; set; }

    public string? NrVoo { get; set; }

    public DateTime? DataHoraVoo { get; set; }

    public int? Ordem { get; set; }

    public DateTime? HoraPrevistaPartida { get; set; }

    public DateTime? HoraPrevistaChegada { get; set; }

    public string? SeloPartida { get; set; }

    public string? SeloChegada { get; set; }

    public bool? PltOrigem { get; set; }
}
