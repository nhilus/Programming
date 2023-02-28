using System;
using System.Collections.Generic;

namespace GCOM2Users.Models;

public partial class InterfacesClientesParametro
{
    public int? IdCliente { get; set; }

    public int? IdClienteUnix { get; set; }

    public string? FtpServer { get; set; }

    public string? FtpUser { get; set; }

    public string? FtpPwd { get; set; }

    public string? FtpFolder { get; set; }

    public string? TempFolder { get; set; }

    public bool? Activo { get; set; }

    public bool? ClientAwbfileName { get; set; }

    public bool? RangelAwbfileName { get; set; }

    public bool? RefClientFileName { get; set; }

    public int? IdCliMorada { get; set; }

    public int? IdEntidade { get; set; }
}
