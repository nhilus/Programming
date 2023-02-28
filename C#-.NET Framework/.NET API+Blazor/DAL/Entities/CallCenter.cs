using System;
using System.Collections.Generic;

namespace DAL.Entities;

public partial class CallCenter
{
    public long? CallId { get; set; }

    public DateTime? CallDate { get; set; }

    public string? Qname { get; set; }

    public bool? Atendida { get; set; }

    public bool? AtendidaOnTime { get; set; }

    public int? Duration { get; set; }

    public int? CallDuration { get; set; }

    public string? Utilizador { get; set; }

    public string? CodUtilizador { get; set; }

    public string? Phone { get; set; }
}
