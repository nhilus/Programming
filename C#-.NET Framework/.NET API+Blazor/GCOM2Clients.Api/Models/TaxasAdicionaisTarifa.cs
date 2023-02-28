using System;
using System.Collections.Generic;

namespace GCOM2Users.Models;

public partial class TaxasAdicionaisTarifa
{
    public int Id { get; set; }

    public int? IdTaxaAdicional { get; set; }

    public int? IdTarifa { get; set; }

    public int? IdEntidade { get; set; }

    public int? IdRegime { get; set; }

    public int? IdServico { get; set; }

    public DateTime? DtIntrod { get; set; }
}
