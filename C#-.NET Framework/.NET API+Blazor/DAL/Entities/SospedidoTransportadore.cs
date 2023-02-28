using System;
using System.Collections.Generic;

namespace DAL.Entities;

public partial class SospedidoTransportadore
{
    public int Id { get; set; }

    public int? IdClienteFornecedor { get; set; }

    public int? IdEntidade { get; set; }

    public bool? EnvProposta { get; set; }

    public bool? RespProposta { get; set; }

    public bool? Disponivel { get; set; }

    public decimal? Custo { get; set; }

    public bool? Seleccionado { get; set; }

    public DateTime? DtIntrod { get; set; }

    public int? IdUtilIntrod { get; set; }

    public DateTime? DtUltAct { get; set; }

    public int? IdUtilUltAct { get; set; }

    public int? IdSospedido { get; set; }

    public int? IdViatura { get; set; }
}
