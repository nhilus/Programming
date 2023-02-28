using System;
using System.Collections.Generic;

namespace DAL.Entities;

public partial class EmailSalesLeadLog
{
    public int Id { get; set; }

    public string? Sender { get; set; }

    public string? EmailRecebido { get; set; }

    public string? ErroInterno { get; set; }

    public DateTime? DtUltAct { get; set; }
}
