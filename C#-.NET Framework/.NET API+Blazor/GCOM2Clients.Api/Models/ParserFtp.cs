using System;
using System.Collections.Generic;

namespace GCOM2Users.Models;

public partial class ParserFtp
{
    public int? IdCliente { get; set; }

    public string SourceType { get; set; } = null!;

    public string? SourceFtpServer { get; set; }

    public string? SourceBackupDir { get; set; }

    public string? SourceFtpUser { get; set; }

    public string? SourceFtpPassword { get; set; }

    public string? Dir { get; set; }

    public string? FilePrefix { get; set; }

    public string? FileExtension { get; set; }

    public int CheckBackupDir { get; set; }

    public int AddFilePrefix { get; set; }

    public int Id { get; set; }
}
