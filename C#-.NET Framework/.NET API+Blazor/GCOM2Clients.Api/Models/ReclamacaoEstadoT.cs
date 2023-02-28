using System;
using System.Collections.Generic;

namespace GCOM2Users.Models;

public partial class ReclamacaoEstadoT
{
    public int Id { get; set; }

    public string Descricao { get; set; } = null!;

    public int IdEntidade { get; set; }

    public bool Concluido { get; set; }

    public bool Externo { get; set; }

    public bool? Activo { get; set; }

    public int? MaxMinutosResposta { get; set; }

    public int? MaxMinutosRespostaSup { get; set; }
}
