using System;
using System.Collections.Generic;

namespace GCOM2Users.Models;

public partial class SospedidoItem
{
    public int Id { get; set; }

    public int IdSospedido { get; set; }

    public int IdServicoDet { get; set; }
}
