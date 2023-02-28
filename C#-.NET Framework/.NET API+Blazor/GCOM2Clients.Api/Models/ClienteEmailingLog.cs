using System;
using System.Collections.Generic;

namespace GCOM2Users.Models;

public partial class ClienteEmailingLog
{
    public int Id { get; set; }

    public string IdEmailing { get; set; } = null!;

    public DateTime DtEnviado { get; set; }
}
