using System;
using System.Collections.Generic;

namespace GCOM2Users.Models;

public partial class MaterialPedidoJustificacaoT
{
    public byte Id { get; set; }

    public string Descricao { get; set; } = null!;

    public int IdUtilIntrod { get; set; }

    public DateTime DtIntrod { get; set; }

    public int IdUtilUltAct { get; set; }

    public DateTime DtUltAct { get; set; }

    public bool? Activo { get; set; }
}
