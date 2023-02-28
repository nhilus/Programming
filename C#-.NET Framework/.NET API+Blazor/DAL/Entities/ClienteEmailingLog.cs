using System;
using System.Collections.Generic;

namespace DAL.Entities;

public partial class ClienteEmailingLog
{
    public int Id { get; set; }

    public string IdEmailing { get; set; } = null!;

    public DateTime DtEnviado { get; set; }
}
