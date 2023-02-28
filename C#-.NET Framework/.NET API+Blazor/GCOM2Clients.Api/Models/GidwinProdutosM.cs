using System;
using System.Collections.Generic;

namespace GCOM2Users.Models;

public partial class GidwinProdutosM
{
    public int Id { get; set; }

    public int CodGidwin { get; set; }

    public int IdProdutoTipo { get; set; }

    public int IdEntidade { get; set; }

    public string? TipoRubrica { get; set; }

    public string? Descricao { get; set; }

    public int? CgTpProdutoVang { get; set; }
}
