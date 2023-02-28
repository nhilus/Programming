using System;
using System.Collections.Generic;

namespace GCOM2Users.Models;

public partial class ClienteParserParametro
{
    public int Id { get; set; }

    public int? IdCliente { get; set; }

    public int? IdExpedidor { get; set; }

    public string? FilePrefix { get; set; }

    public string? FileExtension { get; set; }

    public bool? Prioritario { get; set; }

    public bool? AplicarRegras { get; set; }

    public bool? GerarRecolha { get; set; }

    public int? RegrasClasseOrigem { get; set; }

    public string? DelimiterChar { get; set; }

    public string? Dir { get; set; }

    public int? FileType { get; set; }

    public int? SourceTypeId { get; set; }

    public string? SourceFtpServer { get; set; }

    public string? SourceFtpUser { get; set; }

    public string? SourceFtpPassword { get; set; }

    public string? SourceBackupDir { get; set; }

    public string? FtpServer { get; set; }

    public string? FtpUser { get; set; }

    public string? FtpPassword { get; set; }

    public string? FtpDir { get; set; }

    public bool? Activo { get; set; }

    public int? IdClienteUnix { get; set; }

    public int? RecordId { get; set; }

    public int? IdClienteEmissao { get; set; }

    public bool? ConcatenarPrefixo { get; set; }

    public int? IdUtilIntrod { get; set; }

    public DateTime? DtIntrod { get; set; }

    public int? IdUtilUltAct { get; set; }

    public DateTime? DtUltAct { get; set; }

    public string? MoveToDir { get; set; }

    public bool? GuiasImpressas { get; set; }

    public string? Observacoes { get; set; }

    public bool? CheckBackupDir { get; set; }

    public string? AddFilePrefix { get; set; }

    public int? IdCliMorada { get; set; }

    public int? IdEntidade { get; set; }

    public int? Processamento { get; set; }

    public int? TipoConsolidado { get; set; }

    public bool? PrevEntrega { get; set; }

    public bool? SendEmail { get; set; }
}
