using System;
using System.Collections.Generic;

namespace DAL.Entities;

public partial class IpbrickWaitingCallsLog
{
    public int Id { get; set; }

    public string? QueueName { get; set; }

    public string? WaitingCalls { get; set; }

    public string? HttpRequest { get; set; }

    public string? Error { get; set; }

    public DateTime? DtIntrod { get; set; }
}
