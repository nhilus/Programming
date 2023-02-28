using System;
using System.Collections.Generic;

namespace GCOM2Users.Models;

public partial class NotificacaoPersonalizadum
{
    public int IdClienteNotificacao { get; set; }

    public string? Subject { get; set; }

    public string? Message { get; set; }

    public string? EmailFrom { get; set; }

    public string? EmailTo { get; set; }

    public string? PhonesTo { get; set; }

    public bool? Activo { get; set; }

    public int? IdUtilIntrod { get; set; }

    public DateTime? DtIntrod { get; set; }

    public int? IdUltAct { get; set; }

    public DateTime? DtUltAct { get; set; }
}
