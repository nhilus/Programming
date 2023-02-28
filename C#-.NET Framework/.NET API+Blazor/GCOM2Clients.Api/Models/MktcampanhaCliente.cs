using System;
using System.Collections.Generic;

namespace GCOM2Users.Models;

public partial class MktcampanhaCliente
{
    public int IdCampanha { get; set; }

    public int IdCliente { get; set; }

    public DateTime Data { get; set; }
}
