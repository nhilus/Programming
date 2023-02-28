using System;
using System.Collections.Generic;

namespace GCOM2Users.Models;

public partial class ConferenciaTxDespAlf
{
    public int Id { get; set; }

    public decimal TxDespAlf { get; set; }

    public DateTime DtInicio { get; set; }

    public DateTime? DtFim { get; set; }

    public bool Activo { get; set; }

    public int? IdEntidade { get; set; }

    public int? IdMoeda { get; set; }
}
