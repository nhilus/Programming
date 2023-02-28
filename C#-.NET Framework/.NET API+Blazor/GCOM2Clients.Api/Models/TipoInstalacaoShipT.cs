using System;
using System.Collections.Generic;

namespace GCOM2Users.Models;

public partial class TipoInstalacaoShipT
{
    public int Id { get; set; }

    public string? Descricao { get; set; }

    public int? IdEntidade { get; set; }
}
