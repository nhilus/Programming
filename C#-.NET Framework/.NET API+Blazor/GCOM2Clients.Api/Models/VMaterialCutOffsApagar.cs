using System;
using System.Collections.Generic;

namespace GCOM2Users.Models;

public partial class VMaterialCutOffsApagar
{
    public int Id { get; set; }

    public string? Morada { get; set; }

    public string? Cp4 { get; set; }

    public string? Cp3 { get; set; }

    public string? Localidade { get; set; }

    public int? IdPlataforma { get; set; }

    public int? IdRotaDefault { get; set; }

    public string? RotaDefault { get; set; }

    public DateTime? HoraLimite { get; set; }

    public DateTime? CutOff1 { get; set; }

    public DateTime? CutOff2 { get; set; }
}
