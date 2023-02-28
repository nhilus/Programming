using System;
using System.Collections.Generic;

namespace GCOM2Users.Models;

public partial class ControloPaletesTotai
{
    public int Id { get; set; }

    public int? IdCliente { get; set; }

    public int? Recebidas { get; set; }

    public int? DevEfectivas { get; set; }

    public int? DevNaoEfectivas { get; set; }

    public int? NaoGeradasDev { get; set; }

    public int? Saldo { get; set; }
}
