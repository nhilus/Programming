using System;
using System.Collections.Generic;

namespace DAL.Entities;

public partial class Awbcounter
{
    public int? IdCliente { get; set; }

    public DateTime? CounterDate { get; set; }

    public int? Value { get; set; }

    public int? IdCliMorada { get; set; }

    public int? IdEntidade { get; set; }
}
