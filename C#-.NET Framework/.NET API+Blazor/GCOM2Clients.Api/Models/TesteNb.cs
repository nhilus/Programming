using System;
using System.Collections.Generic;

namespace GCOM2Users.Models;

public partial class TesteNb
{
    public int IdPlataforma { get; set; }

    public int IdRota { get; set; }

    public int? IdMotorista { get; set; }

    public DateTime? Data { get; set; }

    public int? NumStopsEnvios { get; set; }

    public int? VolumesEntrega { get; set; }

    public decimal? PesoEntrega { get; set; }

    public decimal? CustoEntrega { get; set; }

    public int? NumRegEntrega { get; set; }

    public int? NumStopsRecolha { get; set; }

    public int? VolumesRecolha { get; set; }

    public decimal? PesoRecolha { get; set; }

    public decimal? CustoRecolha { get; set; }

    public int? NumRegRecolha { get; set; }

    public decimal? ValoresAdicionais { get; set; }
}
