using System;
using System.Collections.Generic;

namespace GCOM2Users.Models;

public partial class Atest
{
    public int AuditTestId { get; set; }

    public string? Val1 { get; set; }

    public int? Val3 { get; set; }

    public bool Val4 { get; set; }

    public DateTime Val5 { get; set; }

    public int IdUtilUltAct { get; set; }

    public DateTime DtUltAct { get; set; }
}
