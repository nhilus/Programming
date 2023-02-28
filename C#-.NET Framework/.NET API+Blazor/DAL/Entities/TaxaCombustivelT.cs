using System;
using System.Collections.Generic;

namespace DAL.Entities;

public partial class TaxaCombustivelT
{
    public int Id { get; set; }

    public DateTime DataIni { get; set; }

    public DateTime DataFim { get; set; }

    public decimal TxCusto { get; set; }

    public decimal TxVenda { get; set; }

    public int? ZonaTaxa { get; set; }

    public int IdEntidade { get; set; }

    public DateTime DtIntrod { get; set; }

    public int IdUtilIntrod { get; set; }

    public DateTime? DtUltAct { get; set; }

    public int? IdUtilUltAct { get; set; }
}
