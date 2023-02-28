using System;
using System.Collections.Generic;

namespace GCOM2Users.Models;

public partial class NotificacoesDetalhe
{
    public int Id { get; set; }

    public int IdNotificacao { get; set; }

    public int? IdNotificacaoContexto { get; set; }

    public int IdRegisto { get; set; }

    public DateTime? DtIntrod { get; set; }

    public string? TabelaReferencia { get; set; }
}
