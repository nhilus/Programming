using System;
using System.Collections.Generic;

namespace GCOM2Users.Models;

public partial class Entrevistum
{
    public int Id { get; set; }

    /// <summary>
    /// data em que e marcada ou introduzida
    /// </summary>
    public DateTime DtCriacao { get; set; }

    public int? IdUtilCriacao { get; set; }

    /// <summary>
    /// data em q entrevista e&apos; introduzida (nao marcada)
    /// </summary>
    public DateTime? DtIntrod { get; set; }

    public DateTime? DtMarcada { get; set; }

    public int? IdUtilMarcada { get; set; }

    public DateTime? DtInicio { get; set; }

    public int IdUtil { get; set; }

    public int IdCliente { get; set; }

    public bool? NaoAtendeu { get; set; }

    public short? Duracao { get; set; }

    public string? Observacoes { get; set; }

    public int? IdFormato { get; set; }

    public int? IdTipo { get; set; }

    public bool? Automatica { get; set; }

    public bool? Remarcada { get; set; }

    public int? IdEntrevistaOrigem { get; set; }

    public int? IdEntrevistaResposta { get; set; }

    public bool? Efectuada { get; set; }

    public int? IGCOM2Userserta { get; set; }

    public bool Anulada { get; set; }

    public DateTime? DtAnulada { get; set; }

    public int? IdUtilAnulada { get; set; }

    public int IdEntidade { get; set; }

    public int? IdUtilUltAct { get; set; }

    public DateTime? DtUltAct { get; set; }

    public int? IdResultado { get; set; }

    public string? Awb { get; set; }

    public int? IdCliMorada { get; set; }

    public string? ObsEntrave { get; set; }

    public string? ObsPlanoAccao { get; set; }

    public string? ObsObjectivo { get; set; }

    public int? IdEntrave { get; set; }
}
