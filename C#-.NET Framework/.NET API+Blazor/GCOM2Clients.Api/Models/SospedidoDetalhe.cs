using System;
using System.Collections.Generic;

namespace GCOM2Users.Models;

public partial class SospedidoDetalhe
{
    public int Id { get; set; }

    public int IdSospedido { get; set; }

    public DateTime DtIntrod { get; set; }

    public int IdUtilIntrod { get; set; }

    public string? Observacoes { get; set; }

    public int IdTipoDetalhe { get; set; }
}
