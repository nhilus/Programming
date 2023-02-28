using System;
using System.Collections.Generic;

namespace GCOM2Users.Models;

public partial class CallcenterTratar
{
    public long CallId { get; set; }

    public DateTime? CallDate { get; set; }

    public string? Qname { get; set; }

    public string? Phone { get; set; }

    public int? Duracao { get; set; }

    public int? IdTratamento { get; set; }

    public int? IdEntrevista { get; set; }

    public DateTime? DtIntrod { get; set; }

    public int? IdUtilIntrod { get; set; }

    public DateTime? DtUltAct { get; set; }

    public int? IdUtilUltAct { get; set; }
}
