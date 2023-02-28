using System;
using System.Collections.Generic;

namespace GCOM2Users.Models;

public partial class ReclamacaoLocalT
{
    public int Id { get; set; }

    public string Descricao { get; set; } = null!;

    public int? IdGrupo { get; set; }

    public int? IdDepartamento { get; set; }

    public int? IdPlataforma { get; set; }

    public int IdEntidade { get; set; }

    public bool? Activo { get; set; }
}
