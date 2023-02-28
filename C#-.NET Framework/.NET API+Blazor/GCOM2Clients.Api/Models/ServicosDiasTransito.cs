using System;
using System.Collections.Generic;

namespace GCOM2Users.Models;

public partial class ServicosDiasTransito
{
    public int Id { get; set; }

    public int IdServico { get; set; }

    public string ZonaOrigem { get; set; } = null!;

    public string ZonaDestino { get; set; } = null!;

    public int DiasTransito { get; set; }
}
