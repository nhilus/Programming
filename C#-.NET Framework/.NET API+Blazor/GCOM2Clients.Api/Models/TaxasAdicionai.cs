using System;
using System.Collections.Generic;

namespace GCOM2Users.Models;

public partial class TaxasAdicionai
{
    public int Id { get; set; }

    public int? IdServicoDet { get; set; }

    public int? IdEntidade { get; set; }

    public int? IdRegime { get; set; }

    public int? IdServico { get; set; }

    public decimal? Valor { get; set; }

    public DateTime? DtInicio { get; set; }

    public DateTime? DtFim { get; set; }

    public int? IdMoeda { get; set; }

    public int? IdUtilIntrod { get; set; }

    public DateTime? DtIntrod { get; set; }

    public int? IdUtilUltAct { get; set; }

    public DateTime? DtUltAct { get; set; }
}
