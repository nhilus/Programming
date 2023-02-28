using System;
using System.Collections.Generic;

namespace GCOM2Users.Models;

public partial class ClienteTipoLog
{
    public int Id { get; set; }

    public int Idcliente { get; set; }

    public int Idtiponovo { get; set; }

    public DateTime DataAct { get; set; }

    public int? NEntrevistas { get; set; }

    public decimal? ValorDesvio { get; set; }

    public int? IdCliMorada { get; set; }
}
