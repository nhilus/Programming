using System;
using System.Collections.Generic;

namespace DAL.Entities;

public partial class ControloPalete
{
    public int Id { get; set; }

    public int? IdCliente { get; set; }

    public int? IdRota { get; set; }

    public DateTime? Data { get; set; }

    public int? NrPaletes { get; set; }

    public DateTime? Dtintrod { get; set; }

    public int? IdUtilIntrod { get; set; }
}
