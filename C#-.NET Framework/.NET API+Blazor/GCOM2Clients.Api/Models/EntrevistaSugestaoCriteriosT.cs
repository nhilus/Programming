using System;
using System.Collections.Generic;

namespace GCOM2Users.Models;

public partial class EntrevistaSugestaoCriteriosT
{
    public short Id { get; set; }

    public string Codigo { get; set; } = null!;

    public string Descricao { get; set; } = null!;

    public bool? Activo { get; set; }

    public byte? IdDepartamentoDestino { get; set; }
}
