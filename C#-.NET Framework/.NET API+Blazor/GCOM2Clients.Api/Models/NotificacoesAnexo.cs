using System;
using System.Collections.Generic;

namespace GCOM2Users.Models;

public partial class NotificacoesAnexo
{
    public int Id { get; set; }

    public int IdNotificacao { get; set; }

    public int CodAdos { get; set; }

    public string? Descricao { get; set; }
}
