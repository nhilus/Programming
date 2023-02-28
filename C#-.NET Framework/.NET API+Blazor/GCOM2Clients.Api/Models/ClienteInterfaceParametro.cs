using System;
using System.Collections.Generic;

namespace GCOM2Users.Models;

public partial class ClienteInterfaceParametro
{
    public int Id { get; set; }

    public int IdCliente { get; set; }

    public int IdCliMorada { get; set; }

    public int IdEntidade { get; set; }

    public string CodInterface { get; set; } = null!;

    public string? FtpType { get; set; }

    public string? FtpServer { get; set; }

    public string? FtpUser { get; set; }

    public string? FtpPassword { get; set; }

    public string? FtpDir { get; set; }

    public string? NotificationEmails { get; set; }

    public string? EmailFrom { get; set; }

    public string? EmailTo { get; set; }

    public string? EmailCc { get; set; }

    public string? EmailBcc { get; set; }

    public string? DestinationPath { get; set; }

    public bool? Activo { get; set; }

    public string? TimerGcomnect { get; set; }

    public string? CodInterfaceTipo { get; set; }

    public string? CodInterfaceDestino { get; set; }

    public string? NomeTabela { get; set; }
}
