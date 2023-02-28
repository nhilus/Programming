using System;
using System.Collections.Generic;

namespace GCOM2Users.Models;

public partial class ReclamacaoEstadoGeralT
{
    public int Id { get; set; }

    public string? Descricao { get; set; }

    public bool? Activo { get; set; }
}
