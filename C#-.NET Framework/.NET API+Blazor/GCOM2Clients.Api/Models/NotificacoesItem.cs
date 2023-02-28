using System;
using System.Collections.Generic;

namespace GCOM2Users.Models;

public partial class NotificacoesItem
{
    public int IdNotificacao { get; set; }

    public int? IdNotificacaoCliente { get; set; }

    public int IdNotificacaoManifesto { get; set; }

    public int IdManifesto { get; set; }

    public int IdScan { get; set; }
}
