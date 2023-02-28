using System;
using System.Collections.Generic;

namespace GCOM2Users.Models;

public partial class ContenciosoValorCobrado
{
    public int Id { get; set; }

    public int IdContencioso { get; set; }

    public DateTime DtIntrod { get; set; }

    public int IdUtilIntrod { get; set; }

    public DateTime DtValorCobrado { get; set; }

    public decimal ValorCobrado { get; set; }

    public string? ObsValorCobrado { get; set; }
}
