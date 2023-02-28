using System;
using System.Collections.Generic;

namespace GCOM2Users.Models;

public partial class ClienteEntidadesLoginTipoT
{
    public int Id { get; set; }

    public int IdEntidade { get; set; }

    public string Codigo { get; set; } = null!;

    public string? Descricao { get; set; }

    public bool Activo { get; set; }

    public int? IntegrationSystemId { get; set; }
}
