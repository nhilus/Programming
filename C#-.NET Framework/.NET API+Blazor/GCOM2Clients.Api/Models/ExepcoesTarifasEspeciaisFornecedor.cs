using System;
using System.Collections.Generic;

namespace GCOM2Users.Models;

public partial class ExepcoesTarifasEspeciaisFornecedor
{
    public int Id { get; set; }

    public int? IdRota { get; set; }

    public int? IdFornecedor { get; set; }

    public int? IdTarifaEspecialFornecedor { get; set; }

    public int? IdUtilIntrod { get; set; }

    public DateTime? DtIntrod { get; set; }

    public int? IdUtilUltAct { get; set; }

    public DateTime? DtUltAct { get; set; }
}
