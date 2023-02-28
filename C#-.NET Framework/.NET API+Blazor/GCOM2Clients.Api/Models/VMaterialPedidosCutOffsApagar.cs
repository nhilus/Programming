using System;
using System.Collections.Generic;

namespace GCOM2Users.Models;

public partial class VMaterialPedidosCutOffsApagar
{
    public int Id { get; set; }

    public string? MoradaPed { get; set; }

    public string? CpostalPed { get; set; }

    public string? LocalidadePed { get; set; }

    public int? IdPlataformaPed { get; set; }

    public int? IdRotaDefault { get; set; }

    public string? RotaDefault { get; set; }

    public DateTime? HoraLimitePed { get; set; }

    public DateTime? CutOff1Ped { get; set; }

    public DateTime? CutOff2Ped { get; set; }
}
