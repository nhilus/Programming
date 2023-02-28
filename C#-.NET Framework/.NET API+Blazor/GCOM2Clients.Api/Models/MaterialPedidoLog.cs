using System;
using System.Collections.Generic;

namespace GCOM2Users.Models;

public partial class MaterialPedidoLog
{
    public int Id { get; set; }

    public int IdMaterialPedido { get; set; }

    public int IdUtil { get; set; }

    public DateTime Data { get; set; }

    public int IdAccao { get; set; }

    public string? Observacoes { get; set; }
}
