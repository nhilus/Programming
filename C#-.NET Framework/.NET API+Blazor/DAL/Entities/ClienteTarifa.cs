using System;
using System.Collections.Generic;

namespace DAL.Entities;

public partial class ClienteTarifa
{
    public int Id { get; set; }

    public string Codigo { get; set; } = null!;

    public string? Descricao { get; set; }

    public DateTime? DtInicio { get; set; }

    public DateTime? DtFim { get; set; }

    public int? IdProximaTarifa { get; set; }

    public int IdUtil { get; set; }

    public DateTime DtIntrod { get; set; }

    public bool? Valida { get; set; }

    public int IdEntidade { get; set; }

    public bool? TarifaImp { get; set; }

    public bool? TarifaExp { get; set; }

    public bool? TarifaIp { get; set; }

    public bool? TarifaIpf { get; set; }

    public bool? TarifaIe { get; set; }

    public bool? TarifaIc { get; set; }

    public bool? TarifaRe { get; set; }

    public bool? TarifaRm { get; set; }

    public int? IdTipoTarifa { get; set; }

    public int? IdTarifaBase { get; set; }

    public decimal? DivMargem { get; set; }

    public decimal? MultMargem { get; set; }

    public decimal? AumenMargem { get; set; }

    public decimal? Desconto { get; set; }

    public int? FactEsperada { get; set; }

    public int? FactMax { get; set; }

    public bool? Default { get; set; }

    public bool? Activa { get; set; }

    public bool? Prioridade { get; set; }

    public decimal? Factseguinte { get; set; }

    public int? IdCliente { get; set; }

    public bool Tb { get; set; }

    public int? IdCliMorada { get; set; }
}
