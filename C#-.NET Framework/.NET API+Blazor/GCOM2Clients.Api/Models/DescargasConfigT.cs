using System;
using System.Collections.Generic;

namespace GCOM2Users.Models;

public partial class DescargasConfigT
{
    public int Id { get; set; }

    public int? IdCliente { get; set; }

    public string? TipoLeitura { get; set; }

    public int? TamanhoLeitura { get; set; }

    public bool? AplicaScan { get; set; }

    public bool? Activo { get; set; }
}
