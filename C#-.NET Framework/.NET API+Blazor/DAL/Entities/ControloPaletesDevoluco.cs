using System;
using System.Collections.Generic;

namespace DAL.Entities;

public partial class ControloPaletesDevoluco
{
    public int Id { get; set; }

    public int? IdCliente { get; set; }

    public int? IdManifesto { get; set; }

    public int? Paletes { get; set; }

    public bool? Entregue { get; set; }

    public int? IdUtilintrod { get; set; }

    public DateTime? DtUltAct { get; set; }

    public int? IdUtilUltAct { get; set; }

    public DateTime? DtIntrod { get; set; }

    public bool? Anulada { get; set; }
}
