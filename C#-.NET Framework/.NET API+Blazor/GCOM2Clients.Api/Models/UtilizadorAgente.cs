using System;
using System.Collections.Generic;

namespace GCOM2Users.Models;

public partial class UtilizadorAgente
{
    public int Id { get; set; }

    public string Codigo { get; set; } = null!;

    public string? Descricao { get; set; }

    public int? IdPlataforma { get; set; }

    public DateTime? DtInicio { get; set; }

    public decimal? CustoMes { get; set; }

    public decimal? CustoDia { get; set; }

    public decimal? CustoRecStop { get; set; }

    public decimal? CustoRecMaster { get; set; }

    public decimal? CustoRecMps { get; set; }

    public decimal? CustoEntStop { get; set; }

    public decimal? CustoEntMaster { get; set; }

    public decimal? CustoEntMps { get; set; }

    public decimal? PenalAwbrec { get; set; }

    public decimal? PenalAwbent { get; set; }

    public DateTime? DtIntrod { get; set; }

    public int? IdUtilIntrod { get; set; }

    public decimal? CustoMinMes { get; set; }

    public decimal? CustoMinDia { get; set; }

    public bool? Activo { get; set; }

    public int IdEntidade { get; set; }
}
