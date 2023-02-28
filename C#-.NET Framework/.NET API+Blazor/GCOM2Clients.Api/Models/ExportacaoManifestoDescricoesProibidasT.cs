using System;
using System.Collections.Generic;

namespace GCOM2Users.Models;

public partial class ExportacaoManifestoDescricoesProibidasT
{
    public int Id { get; set; }

    public string Descricao { get; set; } = null!;

    public string? Detalhe { get; set; }

    public bool? Activo { get; set; }
}
