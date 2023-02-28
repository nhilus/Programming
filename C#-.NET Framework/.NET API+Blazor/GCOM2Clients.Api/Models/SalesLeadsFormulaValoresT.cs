using System;
using System.Collections.Generic;

namespace GCOM2Users.Models;

public partial class SalesLeadsFormulaValoresT
{
    public int Id { get; set; }

    public int IdEntidade { get; set; }

    public int IdDepartUtil { get; set; }

    public int Fase { get; set; }

    public decimal? Escalao { get; set; }

    public decimal? EscalaoSeg { get; set; }

    public decimal Valor { get; set; }
}
