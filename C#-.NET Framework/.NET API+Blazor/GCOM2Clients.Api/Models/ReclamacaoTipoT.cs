using System;
using System.Collections.Generic;

namespace GCOM2Users.Models;

public partial class ReclamacaoTipoT
{
    public int Id { get; set; }

    public string Descricao { get; set; } = null!;

    public int IdEntidade { get; set; }

    public bool? Activo { get; set; }
}
