using System;
using System.Collections.Generic;

namespace GCOM2Users.Models;

public partial class ClienteTarifasLog
{
    public int Id { get; set; }

    public int IdCliente { get; set; }

    public int IdTarifa { get; set; }

    public int? IdTipoAgrupa { get; set; }

    public int? IdTipoAgrupaRep { get; set; }

    public decimal UnidArredonda { get; set; }

    public decimal PercDesconto { get; set; }

    public DateTime Data { get; set; }

    public DateTime? DtFim { get; set; }

    public string? Observacoes { get; set; }

    public bool RubricaObrigatoria { get; set; }

    public decimal? FactEsperada { get; set; }

    public decimal? FactMinEsperada { get; set; }

    public DateTime DtIntrod { get; set; }

    public int IdUtilIntrod { get; set; }

    public DateTime DtUltAct { get; set; }

    public int? IdUtilUltAct { get; set; }

    public int? IdClasseOrigem { get; set; }

    public bool? DescUnidAdi { get; set; }

    public decimal? DivVolumetrico { get; set; }

    public int? IdCliMorada { get; set; }

    public bool? ReqValidacao { get; set; }
}
