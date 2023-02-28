using System;
using System.Collections.Generic;

namespace GCOM2Users.Models;

public partial class LineHaulTipoServicoT
{
    public int Id { get; set; }

    public string? Descricao { get; set; }

    public double? Imputacao { get; set; }

    public string? CcustoId { get; set; }

    public string? CcustoNome { get; set; }

    public int? IdEntidade { get; set; }
}
