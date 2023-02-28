using System;
using System.Collections.Generic;

namespace GCOM2Users.Models;

public partial class ClienteLoginHistorico
{
    public int IdCliente { get; set; }

    public DateTime DtLogin { get; set; }

    public string Ip { get; set; } = null!;

    public bool Sucesso { get; set; }

    public DateTime? DtLogoff { get; set; }

    public int Id { get; set; }
}
