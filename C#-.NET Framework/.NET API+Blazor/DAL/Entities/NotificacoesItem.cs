using System;
using System.Collections.Generic;

namespace DAL.Entities;

public partial class NotificacoesItem
{
    public int IdNotificacao { get; set; }

    public int? IdNotificacaoCliente { get; set; }

    public int IdNotificacaoManifesto { get; set; }

    public int IdManifesto { get; set; }

    public int IdScan { get; set; }
}
