﻿using System;
using System.Collections.Generic;

namespace GCOM2Users.Models;

public partial class ClienteTxDescCombLog
{
    public int Id { get; set; }

    public int IdCliente { get; set; }

    public decimal TxDesc { get; set; }

    public DateTime? DtAgendada { get; set; }

    public int IdUtilizador { get; set; }

    public DateTime DtIntrod { get; set; }

    public int IdEntidade { get; set; }

    public int? IdCliMorada { get; set; }
}
