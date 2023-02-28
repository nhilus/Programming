using System;
using System.Collections.Generic;

namespace GCOM2Users.Models;

public partial class ClienteVipLog
{
    public int Id { get; set; }

    public DateTime DtIntrod { get; set; }

    public int IdUtil { get; set; }

    public int IdCliente { get; set; }

    public DateTime Data { get; set; }

    public bool? Vip { get; set; }

    public int IdUtilVip { get; set; }
}
