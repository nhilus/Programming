using System;
using System.Collections.Generic;

namespace DAL.Entities;

public partial class PudoClienteConfigOpco
{
    public int Id { get; set; }

    public int? IdPudoCliente { get; set; }

    public string? CodigoGeral { get; set; }

    public int? IdOpcao { get; set; }

    public int? Activo { get; set; }

    public int? IdUtilIntrod { get; set; }

    public DateTime? DtIntrod { get; set; }

    public int? IdUtilUltAct { get; set; }

    public DateTime? DtUltAct { get; set; }
}
