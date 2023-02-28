using System;
using System.Collections.Generic;

namespace GCOM2Users.Models;

public partial class ClienteContactosTipoAcesso
{
    public int Id { get; set; }

    public int IdContactoTipo { get; set; }

    public int IdGrupo { get; set; }

    public int? Posicao { get; set; }
}
