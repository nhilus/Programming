using System;
using System.Collections.Generic;

namespace GCOM2Users.Models;

public partial class CobrancaMotivosNaoConferirT
{
    public int Id { get; set; }

    public string? Codigo { get; set; }

    public string? Descricao { get; set; }

    public int? IdDepartUtil { get; set; }

    public int? IdDepartAreaDestino { get; set; }
}
