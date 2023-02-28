using System;
using System.Collections.Generic;

namespace GCOM2Users.Models;

public partial class CamposObrigatorio
{
    public int Id { get; set; }

    public int? IdCliente { get; set; }

    public string? Er { get; set; }

    public string? Campo { get; set; }

    public string? ObsCampo { get; set; }

    public string? Tabela { get; set; }

    public bool? Activo { get; set; }

    public string? LblCampo { get; set; }

    public string? CodigoCampo { get; set; }
}
