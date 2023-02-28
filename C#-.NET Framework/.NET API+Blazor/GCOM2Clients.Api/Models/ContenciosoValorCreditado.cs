using System;
using System.Collections.Generic;

namespace GCOM2Users.Models;

public partial class ContenciosoValorCreditado
{
    public int Id { get; set; }

    public int IdContencioso { get; set; }

    public DateTime DtIntrod { get; set; }

    public int IdUtilIntrod { get; set; }

    public DateTime DtValorCreditado { get; set; }

    public decimal ValorCreditado { get; set; }

    public string? ObsValorCreditado { get; set; }
}
