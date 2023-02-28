using System;
using System.Collections.Generic;

namespace DAL.Entities;

public partial class SalesLeadsEnvio
{
    public int Id { get; set; }

    public int IdSalesLead { get; set; }

    public int IdRegime { get; set; }

    public int IdServico { get; set; }

    public int IdPeriocidade { get; set; }

    public int IdPesoMedio { get; set; }

    public int NumeroEnvios { get; set; }
}
