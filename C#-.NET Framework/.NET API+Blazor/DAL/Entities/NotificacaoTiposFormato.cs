using System;
using System.Collections.Generic;

namespace DAL.Entities;

public partial class NotificacaoTiposFormato
{
    public int Id { get; set; }

    public int IdTipoNotificacao { get; set; }

    public int IdFormatoNotificacao { get; set; }

    public int IdEntidade { get; set; }
}
