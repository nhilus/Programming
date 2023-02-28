using System;
using System.Collections.Generic;

namespace DAL.Entities;

public partial class FacturaProformaCab
{
    public int Id { get; set; }

    public string NumDoc { get; set; } = null!;

    public int IdEstado { get; set; }

    public int NumeradorDoc { get; set; }

    public DateTime DtDoc { get; set; }

    public int IdCliente { get; set; }

    public int? IdCliMorada { get; set; }

    public int IdEntidade { get; set; }

    public DateTime? DtVencimento { get; set; }

    public int? IdMoeda { get; set; }

    public decimal? Cambio { get; set; }

    public decimal? ValorDoc { get; set; }

    public decimal? ValorSiva { get; set; }

    public decimal? ValorIva { get; set; }

    public DateTime DtIntrod { get; set; }

    public int? IdUtilIntrod { get; set; }

    public DateTime? DtUltAct { get; set; }

    public DateTime? DtFecho { get; set; }

    public int? IdUtilFecho { get; set; }

    public DateTime? DtEmissao { get; set; }

    public int? IdUtilEmissao { get; set; }

    public DateTime? DtAnulacao { get; set; }

    public int? IdUtilAnulacao { get; set; }

    public string? Observacoes { get; set; }

    public int? AnoDoc { get; set; }

    public bool? Anulado { get; set; }
}
