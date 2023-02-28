using System;
using System.Collections.Generic;

namespace GCOM2Users.Models;

public partial class UtilizadorAcessosUrlLog
{
    public int Id { get; set; }

    public int IdUtil { get; set; }

    public int IdMenuUrl { get; set; }

    public string Url { get; set; } = null!;

    public string Qstring { get; set; } = null!;

    public string Pbstring { get; set; } = null!;

    public int Permissao { get; set; }

    public DateTime DtAcesso { get; set; }
}
