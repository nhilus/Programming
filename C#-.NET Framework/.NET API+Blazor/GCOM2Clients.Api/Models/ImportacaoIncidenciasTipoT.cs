using System;
using System.Collections.Generic;

namespace GCOM2Users.Models;

public partial class ImportacaoIncidenciasTipoT
{
    public int Id { get; set; }

    public string Descricao { get; set; } = null!;

    public int IdEntidade { get; set; }

    public bool? Activo { get; set; }

    public int? IdTipoNc { get; set; }
}
