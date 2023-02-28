using System;
using System.Collections.Generic;

namespace GCOM2Users.Models;

public partial class MenuUrlgrupo
{
    public int Id { get; set; }

    public int IdGrupo { get; set; }

    public int IdEntidade { get; set; }

    public int IdMenuUrl { get; set; }

    public bool TodosUtilizadores { get; set; }

    public bool TodosClientes { get; set; }

    public bool? TodasPlataformas { get; set; }

    public byte Permissao { get; set; }

    /// <summary>
    /// indica se o link (listar/novo/...) está disponível
    /// </summary>
    public bool? Visivel { get; set; }

    /// <summary>
    /// indica para cada grupo qual opcao aparece por default
    /// </summary>
    public bool Default { get; set; }

    public int? PVisualizar { get; set; }

    public int? PEditar { get; set; }

    public bool? Activo { get; set; }

    public bool? TodasEntidades { get; set; }
}
