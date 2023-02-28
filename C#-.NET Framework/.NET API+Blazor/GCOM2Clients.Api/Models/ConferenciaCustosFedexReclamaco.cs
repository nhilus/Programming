using System;
using System.Collections.Generic;

namespace GCOM2Users.Models;

public partial class ConferenciaCustosFedexReclamaco
{
    public int Id { get; set; }

    public int IdConf { get; set; }

    public int IdUtilIntrod { get; set; }

    public DateTime DtIntrod { get; set; }

    public decimal? CustoReclamado { get; set; }

    public DateTime? DtCustoReclamado { get; set; }

    public decimal? CustoCreditado { get; set; }

    public DateTime? DtCustoCreditado { get; set; }

    public string? ObsReclamado { get; set; }

    public string? ObsCreditado { get; set; }

    public bool Encerrada { get; set; }

    public int? IdUtilUltAct { get; set; }

    public DateTime? DtUltAct { get; set; }

    public bool NewSchema { get; set; }
}
