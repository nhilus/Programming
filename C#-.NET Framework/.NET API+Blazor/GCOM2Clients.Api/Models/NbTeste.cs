using System;
using System.Collections.Generic;

namespace GCOM2Users.Models;

public partial class NbTeste
{
    public int IdProducaoCustosPenalizacoes { get; set; }

    public int IdManifestoCustoReal { get; set; }

    public int? IdManifesto { get; set; }

    public string? Awb { get; set; }

    public int? IdTipoCusto { get; set; }

    public int? IdPlataforma { get; set; }

    public int? IdRota { get; set; }

    public int? IdMotorista { get; set; }

    public int? IdEntidade { get; set; }

    public DateTime? DataCusto { get; set; }

    public int? DateKey { get; set; }

    public int? CustoPrevisto { get; set; }

    public decimal? CustoReal { get; set; }

    public decimal? CustoRealA { get; set; }

    public decimal? CustoRealB { get; set; }
}
