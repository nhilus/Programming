using System;
using System.Collections.Generic;

namespace DAL.Entities;

public partial class WsauthLog
{
    public int Id { get; set; }

    public string Ticket { get; set; } = null!;

    public DateTime Validade { get; set; }
}
