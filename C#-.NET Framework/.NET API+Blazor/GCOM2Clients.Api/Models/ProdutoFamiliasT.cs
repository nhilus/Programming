using System;
using System.Collections.Generic;

namespace GCOM2Users.Models;

public partial class ProdutoFamiliasT
{
    public int Id { get; set; }

    public string Descricao { get; set; } = null!;

    public string? Observacoes { get; set; }

    public string? ImpExp { get; set; }

    public bool? IncIva { get; set; }

    public string? CodigoVanguarda { get; set; }

    public int? CgTpProdutoVang { get; set; }

    public bool? Activo { get; set; }
}
