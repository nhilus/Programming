using System;
using System.Collections.Generic;

namespace DAL.Entities;

public partial class ClienteTxDespAlfandegariasLog
{
    public int Id { get; set; }

    public int IdCliente { get; set; }

    public decimal TxDespAlf { get; set; }

    public int IdUtilizador { get; set; }

    public DateTime DtIntrod { get; set; }

    public int IdEntidade { get; set; }

    public int? IdCliMorada { get; set; }
}
