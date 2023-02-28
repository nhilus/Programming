using System;
using System.Collections.Generic;

namespace DAL.Entities;

public partial class ClienteEntidadesPotNeg
{
    public int Id { get; set; }

    public int IdEntidade { get; set; }

    public int IdCliente { get; set; }

    public int? IdCliMorada { get; set; }

    public int IdRegime { get; set; }

    public int IdServico { get; set; }

    public int IdPotNegZona { get; set; }

    public decimal Potencial { get; set; }

    public decimal Negociado { get; set; }

    public DateTime DtUltAct { get; set; }

    public int IdUtilUltAct { get; set; }
}
