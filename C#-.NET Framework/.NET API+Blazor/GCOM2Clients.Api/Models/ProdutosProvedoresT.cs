using System;
using System.Collections.Generic;

namespace GCOM2Users.Models;

public partial class ProdutosProvedoresT
{
    public int Id { get; set; }

    public int IdProduto { get; set; }

    public int IdProvedor { get; set; }

    public string CodigoProdutoProvedor { get; set; } = null!;
}
