using System;
using System.Collections.Generic;

namespace GCOM2Users.Models;

public partial class SospedidoMotivoRejeitadoT
{
    public int Id { get; set; }

    public string DescCurta { get; set; } = null!;

    public string Descricao { get; set; } = null!;

    public bool? Activo { get; set; }
}
