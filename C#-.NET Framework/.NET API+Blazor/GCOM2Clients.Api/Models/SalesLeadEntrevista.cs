using System;
using System.Collections.Generic;

namespace GCOM2Users.Models;

public partial class SalesLeadEntrevista
{
    public int Id { get; set; }

    public int IdSalesLead { get; set; }

    public int IdEntrevistaOrig { get; set; }

    public int? IdEntrevistaDestino { get; set; }
}
