using System;
using System.Collections.Generic;

namespace GCOM2Users.Models;

public partial class PudoClienteConfig
{
    public int Id { get; set; }

    public int? IdTipoConfig { get; set; }

    public int? IdCliente { get; set; }

    public int? IdCliMorada { get; set; }

    public int? IdPudo { get; set; }

    public int? TempoRetencao { get; set; }

    public string? MetodoNotificacao { get; set; }

    public bool? Activo { get; set; }

    public int? IdUtilIntrod { get; set; }

    public DateTime? Dtintrod { get; set; }

    public int? IdUtilUltAct { get; set; }

    public DateTime? DtUltAct { get; set; }
}
