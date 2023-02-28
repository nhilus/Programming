using System;
using System.Collections.Generic;

namespace DAL.Entities;

public partial class CampanhasPremiosCliente
{
    public int IdCampanhaPremio { get; set; }

    public int IdCliente { get; set; }

    public int IdCliMorada { get; set; }

    public int IdEntidade { get; set; }

    public DateTime? DtPedido { get; set; }

    public DateTime? DtEntrega { get; set; }

    public int? IdUtilIntrod { get; set; }

    public DateTime? DtIntrod { get; set; }

    public int? IdUtilUltAct { get; set; }

    public DateTime? DtUltAct { get; set; }
}
