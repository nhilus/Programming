using System;
using System.Collections.Generic;

namespace GCOM2Users.Models;

public partial class FornecedorLineHaul
{
    public int Id { get; set; }

    public int? IdFornecedor { get; set; }

    public string? Percurso { get; set; }

    public decimal? Custo { get; set; }

    public decimal? Portagens { get; set; }

    public DateTime? DataInicio { get; set; }

    public DateTime? Datafim { get; set; }

    public bool? Activo { get; set; }
}
