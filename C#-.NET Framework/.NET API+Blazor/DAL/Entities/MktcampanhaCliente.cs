using System;
using System.Collections.Generic;

namespace DAL.Entities;

public partial class MktcampanhaCliente
{
    public int IdCampanha { get; set; }

    public int IdCliente { get; set; }

    public DateTime Data { get; set; }
}
