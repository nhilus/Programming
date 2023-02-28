using System;
using System.Collections.Generic;

namespace DAL.Entities;

public partial class Notificaco
{
    public int Id { get; set; }

    public string? PhonesTo { get; set; }

    public string? EmailsTo { get; set; }

    public string? EmailsCc { get; set; }

    public string? EmailsBcc { get; set; }

    public bool? EmailUnico { get; set; }

    public string? Subject { get; set; }

    public string? Message { get; set; }

    public DateTime? DtIntrod { get; set; }

    public DateTime? DtEnviar { get; set; }

    public DateTime? DtEnviada { get; set; }

    public int IdCliente { get; set; }

    public int? IdCliMorada { get; set; }

    public int IdEntidade { get; set; }

    public DateTime? DtEnviadoPortal { get; set; }

    public bool? EnvioInstantaneo { get; set; }

    public bool? EnvioPorRelatorio { get; set; }

    public TimeSpan? HoraInicio { get; set; }

    public TimeSpan? HoraFim { get; set; }

    public int? MinutosRecorrencia { get; set; }

    public string? SubjectRelatorio { get; set; }

    public string? MessageRelatorio { get; set; }

    public bool? ErroEnviar { get; set; }

    public string? DescErro { get; set; }

    public int? IdTipoNotificacao { get; set; }

    public int? IdFormatoNotificacao { get; set; }
}
