using System;
using System.Collections.Generic;

namespace DAL.Entities;

public partial class EmailRecolhaLog
{
    public int Id { get; set; }

    public string? Sender { get; set; }

    public string? EmailRecebido { get; set; }

    public string? EmailEnviado { get; set; }

    public int? IdPickup { get; set; }

    public int? IdClimorada { get; set; }

    public string? ErroInterno { get; set; }

    public DateTime? DtUltAct { get; set; }
}
