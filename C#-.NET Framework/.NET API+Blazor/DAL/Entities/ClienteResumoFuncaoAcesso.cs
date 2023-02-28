using System;
using System.Collections.Generic;

namespace DAL.Entities;

public partial class ClienteResumoFuncaoAcesso
{
    public int Id { get; set; }

    public int IdFuncao { get; set; }

    public int IdClienteResumo { get; set; }

    public int Posicao { get; set; }

    public int Permissao { get; set; }

    public bool? Activo { get; set; }
}
