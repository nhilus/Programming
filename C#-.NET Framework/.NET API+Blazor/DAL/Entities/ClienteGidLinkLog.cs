using System;
using System.Collections.Generic;

namespace DAL.Entities;

public partial class ClienteGidLinkLog
{
    public int Id { get; set; }

    public int Idutil { get; set; }

    public DateTime Dtintrod { get; set; }

    public int CliCounter { get; set; }

    public string CliCodi { get; set; } = null!;

    public string Plataforma { get; set; } = null!;
}
