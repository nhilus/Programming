using System;
using System.Collections.Generic;

namespace DAL.Entities;

public partial class ClienteCampanhasLog
{
    public int Id { get; set; }

    public int IdCliente { get; set; }

    public int IdCampanha { get; set; }

    public DateTime? DtInicio { get; set; }

    public DateTime? DtFim { get; set; }

    public DateTime? DtFimMedicao { get; set; }

    public DateTime? DtIntrod { get; set; }

    public int? IdUtilIntrod { get; set; }

    public bool? Activo { get; set; }

    public int? IdCliMorada { get; set; }

    public decimal? Pontos { get; set; }

    public int? IdEntidade { get; set; }

    public int? IdUtilUltAct { get; set; }

    public DateTime? DtUltAct { get; set; }

    public decimal? PontosProvisorios { get; set; }

    public DateTime? DtUltCalculoPontos { get; set; }

    public DateTime? DtUltCalculoPontosProvisorios { get; set; }
}
