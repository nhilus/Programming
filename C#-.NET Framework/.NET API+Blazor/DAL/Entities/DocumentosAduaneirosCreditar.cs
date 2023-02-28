using System;
using System.Collections.Generic;

namespace DAL.Entities;

public partial class DocumentosAduaneirosCreditar
{
    public int Id { get; set; }

    public DateTime DtIntrod { get; set; }

    public int IdUtilIntrod { get; set; }

    public string DocOrig { get; set; } = null!;

    public int IdCabVang { get; set; }

    public string? Awb { get; set; }

    public string DocNovo { get; set; } = null!;

    public int CliCounter { get; set; }

    public int? IdCliente { get; set; }

    public int? IdUtilCliente { get; set; }

    public int? IdDocCredito { get; set; }

    public int? IdCliMorada { get; set; }
}
