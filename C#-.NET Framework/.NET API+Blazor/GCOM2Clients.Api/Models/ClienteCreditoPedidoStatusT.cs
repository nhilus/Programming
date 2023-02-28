using System;
using System.Collections.Generic;

namespace GCOM2Users.Models;

public partial class ClienteCreditoPedidoStatusT
{
    public int Id { get; set; }

    public string Descricao { get; set; } = null!;

    public int IdEntidade { get; set; }

    public bool Respondido { get; set; }

    public bool Aprovado { get; set; }

    public bool Concluido { get; set; }

    public bool? Activo { get; set; }
}
