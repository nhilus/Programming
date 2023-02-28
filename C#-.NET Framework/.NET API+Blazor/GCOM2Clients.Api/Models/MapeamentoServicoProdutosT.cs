using System;
using System.Collections.Generic;

namespace GCOM2Users.Models;

public partial class MapeamentoServicoProdutosT
{
    public int Id { get; set; }

    public int? IdServico { get; set; }

    public string? DescricaoServico { get; set; }

    public int? IdProduto { get; set; }

    public string? DescricaoProduto { get; set; }

    public string? ServicePacking { get; set; }

    public bool? Activo { get; set; }
}
