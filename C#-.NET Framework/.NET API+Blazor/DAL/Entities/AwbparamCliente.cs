using System;
using System.Collections.Generic;

namespace DAL.Entities;

public partial class AwbparamCliente
{
    public int Id { get; set; }

    public int IdCliente { get; set; }

    public string PrefixoAwb { get; set; } = null!;

    public string AwbStart { get; set; } = null!;

    public string AwbEnd { get; set; } = null!;

    public string Obs { get; set; } = null!;

    public int IdUtilIntrod { get; set; }

    public DateTime DtIntrod { get; set; }

    public int IdUtilUltAct { get; set; }

    public DateTime DtUltAct { get; set; }
}
