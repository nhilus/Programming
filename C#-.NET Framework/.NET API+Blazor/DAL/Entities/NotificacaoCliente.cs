using System;
using System.Collections.Generic;

namespace DAL.Entities;

public partial class NotificacaoCliente
{
    public int Id { get; set; }

    public int IdCliente { get; set; }

    public int IdEntidade { get; set; }

    public int? IdCliMorada { get; set; }

    public int IdTipoNotificacao { get; set; }

    public int IdFormatoNotificacao { get; set; }

    public string? EmailsTo { get; set; }

    public string? EmailsCc { get; set; }

    public string? EmailsBcc { get; set; }

    public bool? EmailUnico { get; set; }

    public string? PhonesTo { get; set; }

    public bool? Activo { get; set; }

    public DateTime? DtUltAct { get; set; }

    public int IdUtilUltAct { get; set; }

    public bool? EnvioInstantaneo { get; set; }

    public bool? EnvioPorRelatorio { get; set; }

    public TimeSpan? HoraInicio { get; set; }

    public TimeSpan? HoraFim { get; set; }

    public int? MinutosRecorrencia { get; set; }
}
