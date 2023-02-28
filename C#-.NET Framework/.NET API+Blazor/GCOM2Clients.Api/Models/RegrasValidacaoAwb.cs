using System;
using System.Collections.Generic;

namespace GCOM2Users.Models;

public partial class RegrasValidacaoAwb
{
    public int Id { get; set; }

    public string? RegEx { get; set; }

    public int? IdEntidade { get; set; }

    public int? IdCliente { get; set; }

    public bool? Activo { get; set; }

    public bool? ValidacaoExtra { get; set; }

    public bool? EnvInterface { get; set; }

    public DateTime? DtEnvInterface { get; set; }

    public string? Observacoes { get; set; }

    public int? OrdemValidacao { get; set; }
}
