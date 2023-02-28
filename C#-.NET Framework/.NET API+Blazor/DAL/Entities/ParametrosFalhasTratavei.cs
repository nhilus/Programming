using System;
using System.Collections.Generic;

namespace DAL.Entities;

public partial class ParametrosFalhasTratavei
{
    public int Id { get; set; }

    public int IdCliente { get; set; }

    public int IdCliMorada { get; set; }

    public int? Prazo1 { get; set; }

    public int? Prazo2 { get; set; }

    public string? Email { get; set; }

    public bool? Activo { get; set; }

    public int? IdUtilIntrod { get; set; }

    public DateTime? DtIntrod { get; set; }

    public int? IdUtilUltAct { get; set; }

    public DateTime? DtUtilUltAct { get; set; }

    public bool? SegundoEmail { get; set; }

    public bool? Tratamento { get; set; }
}
