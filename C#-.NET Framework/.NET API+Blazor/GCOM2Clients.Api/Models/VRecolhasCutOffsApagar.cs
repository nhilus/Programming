using System;
using System.Collections.Generic;

namespace GCOM2Users.Models;

public partial class VRecolhasCutOffsApagar
{
    public int Id { get; set; }

    public string? MoradaPup { get; set; }

    public string? Cp4Pup { get; set; }

    public string? Cp3Pup { get; set; }

    public string? LocalidadePup { get; set; }

    public int? IdPlataformaPup { get; set; }

    public int? IdRotaDefault { get; set; }

    public string? RotaDefault { get; set; }

    public DateTime? HoraLimitePup { get; set; }

    public DateTime? CutOff1Pup { get; set; }

    public DateTime? CutOff2Pup { get; set; }
}
