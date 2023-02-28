using System;
using System.Collections.Generic;

namespace GCOM2Users.Models;

public partial class UtilizadorAlertasCount
{
    public int IdUtil { get; set; }

    public int IdEntidade { get; set; }

    public int BackofficesPendentes { get; set; }

    public int BackofficesNovos { get; set; }

    public int AlertasHoje { get; set; }

    public int AlertasSempre { get; set; }

    public int EntrevistasPendentes { get; set; }

    public int EntrevistasAtrasadas { get; set; }

    public int PedidosCreditoPendentes { get; set; }

    public int PickupsTotal { get; set; }

    public int PickupsPendentes { get; set; }

    public int PickupsAnulados { get; set; }

    public int PickupsPendentesUrg { get; set; }

    public int ReclamaPend { get; set; }

    public int ReclamaPendConc { get; set; }

    public int ReclamaPendParaMim { get; set; }

    public int ReclamaPendPorMim { get; set; }

    public int SospedidoSpropCliente { get; set; }

    public int SospedidoCprecoFornecedor { get; set; }

    public int SospedidoSfornecedores { get; set; }

    public int SospedidoAceitesSini { get; set; }
}
