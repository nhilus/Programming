using System;
using System.Collections.Generic;

namespace DAL.Entities;

public partial class SalesLeadEntrevista
{
    public int Id { get; set; }

    public int IdSalesLead { get; set; }

    public int IdEntrevistaOrig { get; set; }

    public int? IdEntrevistaDestino { get; set; }
}
