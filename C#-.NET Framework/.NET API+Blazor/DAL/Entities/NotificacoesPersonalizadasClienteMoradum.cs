using System;
using System.Collections.Generic;

namespace DAL.Entities;

public partial class NotificacoesPersonalizadasClienteMoradum
{
    public int Id { get; set; }

    public int? IdCliente { get; set; }

    public int? IdCliMorada { get; set; }

    public string? Subject { get; set; }

    public string? Msg { get; set; }

    public string? EmailFrom { get; set; }

    public string? EmailTo { get; set; }

    public string? PhonesTo { get; set; }

    public int? Activo { get; set; }

    public DateTime? DtIntrod { get; set; }

    public int? IdUtilItrod { get; set; }

    public int? IdUtilUltAct { get; set; }

    public DateTime? DtUltAct { get; set; }

    public bool? Entrega { get; set; }

    public bool? Recolha { get; set; }
}
