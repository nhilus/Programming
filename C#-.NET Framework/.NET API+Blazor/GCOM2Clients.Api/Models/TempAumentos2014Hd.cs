using System;
using System.Collections.Generic;

namespace GCOM2Users.Models;

public partial class TempAumentos2014Hd
{
    public int? IdCliente { get; set; }

    public byte? IdEntidade { get; set; }

    public int? IdLin { get; set; }

    public int? IdManifesto { get; set; }

    public string? Awb { get; set; }

    public DateTime? Data { get; set; }

    public int? IdServico { get; set; }

    public int? IdServicoDet { get; set; }

    public int? IdRegime { get; set; }

    public int? IdTarifa { get; set; }

    public string? Tarifa { get; set; }

    public decimal? ValorTarifa { get; set; }

    public bool? ValorManual { get; set; }

    public string? NovaTarifa { get; set; }

    public int? IdNovaTarifa { get; set; }

    public decimal? Aumento { get; set; }

    public decimal? ValorNovaTarifa { get; set; }
}
