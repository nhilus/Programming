using System;
using System.Collections.Generic;

namespace GCOM2Users.Models;

public partial class TarifaMotoristaCondico
{
    public int Id { get; set; }

    public int? IdTarifaMotorista { get; set; }

    public TimeSpan? HoraIni { get; set; }

    public TimeSpan? HoraFim { get; set; }

    public decimal? PercValorBase { get; set; }

    public decimal? PercAgrava { get; set; }

    public int? NumStopsIni { get; set; }

    public int? NumStopsFim { get; set; }

    public int? IdUtilIntrod { get; set; }

    public DateTime? DtIntrod { get; set; }

    public decimal? Valor { get; set; }

    public decimal? ValorObjectivo { get; set; }
}
