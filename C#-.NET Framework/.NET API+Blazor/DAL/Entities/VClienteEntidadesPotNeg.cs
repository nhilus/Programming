using System;
using System.Collections.Generic;

namespace DAL.Entities;

public partial class VClienteEntidadesPotNeg
{
    public int IdCliente { get; set; }

    public int IdEntidade { get; set; }

    public int? IdCliMorada { get; set; }

    public int IdRegime { get; set; }

    public string CodRegime { get; set; } = null!;

    public string Regime { get; set; } = null!;

    public int IdServico { get; set; }

    public string CodServico { get; set; } = null!;

    public string Servico { get; set; } = null!;

    public string Zona { get; set; } = null!;

    public decimal Potencial { get; set; }

    public decimal Negociado { get; set; }
}
