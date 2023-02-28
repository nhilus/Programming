using System;
using System.Collections.Generic;

namespace DAL.Entities;

public partial class SospedidoVolume
{
    public int Id { get; set; }

    public int IdSospedido { get; set; }

    public double? Peso { get; set; }

    public double? Comprimento { get; set; }

    public double? Altura { get; set; }

    public double? Largura { get; set; }

    public double? M3 { get; set; }
}
