using System;
using System.Collections.Generic;

namespace DAL.Entities;

public partial class SospedidoItem
{
    public int Id { get; set; }

    public int IdSospedido { get; set; }

    public int IdServicoDet { get; set; }
}
