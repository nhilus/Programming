using System;
using System.Collections.Generic;

namespace DAL.Entities;

public partial class ProdutosProvedoresT
{
    public int Id { get; set; }

    public int IdProduto { get; set; }

    public int IdProvedor { get; set; }

    public string CodigoProdutoProvedor { get; set; } = null!;
}
