using System;
using System.Collections.Generic;

namespace GCOM2Users.Models;

public partial class SalesLeadsEnviosZona
{
    public int Id { get; set; }

    public int IdSalesLead { get; set; }

    public int IdRegime { get; set; }

    public int IdServico { get; set; }

    public int IdZonaPais { get; set; }

    public int Percentagem { get; set; }
}
