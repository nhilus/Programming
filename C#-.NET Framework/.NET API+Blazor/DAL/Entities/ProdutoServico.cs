using System;
using System.Collections.Generic;

namespace DAL.Entities;

public partial class ProdutoServico
{
    public int Id { get; set; }

    public int? IdProduto { get; set; }

    public int? IdProdutoServico { get; set; }

    public int? IdServico { get; set; }

    public string CodigoGrasp { get; set; } = null!;

    public string? SiglaGrasp { get; set; }

    public string? CodigoGraspNovo { get; set; }

    public int? IdEntidade { get; set; }
}
