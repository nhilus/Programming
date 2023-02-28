using System;
using System.Collections.Generic;

namespace DAL.Entities;

public partial class ClienteCampanhaPremiosLog
{
    public int? IdPremio { get; set; }

    public int? IdCampanha { get; set; }

    public int? IdCliente { get; set; }

    public int? IdCliMorada { get; set; }

    public int? IdEntidade { get; set; }

    public decimal? Pontos { get; set; }

    public int? IdUtilIntrod { get; set; }

    public DateTime? DtIntrod { get; set; }
}
