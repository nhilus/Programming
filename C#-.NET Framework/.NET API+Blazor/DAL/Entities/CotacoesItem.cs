using System;
using System.Collections.Generic;

namespace DAL.Entities;

public partial class CotacoesItem
{
    public int Id { get; set; }

    public int IdPickup { get; set; }

    public int IdServico { get; set; }

    public int IdServicoDet { get; set; }

    public decimal? Valor { get; set; }

    public bool Activo { get; set; }

    public int IdUtilIntrod { get; set; }

    public DateTime DtIntrod { get; set; }

    public int? IdUtilUltAct { get; set; }

    public DateTime? DtUltAct { get; set; }

    public int? Idtipoiva { get; set; }

    public int? IdIvareg { get; set; }

    public string? CodIva { get; set; }
}
