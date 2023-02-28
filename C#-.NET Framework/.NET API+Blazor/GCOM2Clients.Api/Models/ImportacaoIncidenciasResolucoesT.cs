using System;
using System.Collections.Generic;

namespace GCOM2Users.Models;

public partial class ImportacaoIncidenciasResolucoesT
{
    public int Id { get; set; }

    public string Codigo { get; set; } = null!;

    public string Descricao { get; set; } = null!;

    public int IdEntidade { get; set; }

    public bool Encerra { get; set; }

    public bool OriginaNc { get; set; }

    public bool? Activo { get; set; }
}
