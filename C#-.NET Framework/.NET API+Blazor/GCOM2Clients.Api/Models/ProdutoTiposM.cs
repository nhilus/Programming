using System;
using System.Collections.Generic;

namespace GCOM2Users.Models;

public partial class ProdutoTiposM
{
    public int? IdCliente { get; set; }

    public int? IdEntidade { get; set; }

    public string? CodigoCliente { get; set; }

    public string? DescricaoCliente { get; set; }

    public int? IdRangel { get; set; }
}
