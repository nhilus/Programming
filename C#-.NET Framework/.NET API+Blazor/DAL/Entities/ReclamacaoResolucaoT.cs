using System;
using System.Collections.Generic;

namespace DAL.Entities;

public partial class ReclamacaoResolucaoT
{
    public int Id { get; set; }

    public string Descricao { get; set; } = null!;

    public int IdEntidade { get; set; }

    public bool AfectaCustos { get; set; }

    public bool? Activo { get; set; }
}
