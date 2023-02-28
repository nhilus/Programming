using System;
using System.Collections.Generic;

namespace GCOM2Users.Models;

public partial class ClienteResumoAcesso
{
    public int Id { get; set; }

    public int IdClienteResumo { get; set; }

    public int IdGrupo { get; set; }

    public int IdEntidade { get; set; }

    public int Posicao { get; set; }

    public int Permissao { get; set; }

    public bool? Activo { get; set; }
}
