using System;
using System.Collections.Generic;

namespace GCOM2Users.Models;

public partial class TarifasEspeciaisFornecedor
{
    public int Id { get; set; }

    public int? IdCliente { get; set; }

    public int? IdEntidade { get; set; }

    public decimal? ValorStop { get; set; }

    public decimal? PesoBrutoMin { get; set; }

    public decimal? PesoBrutoMax { get; set; }

    public DateTime? DtInicio { get; set; }

    public DateTime? DtFim { get; set; }

    public int? IdUtilIntrod { get; set; }

    public DateTime? DtIntrod { get; set; }

    public int? IdUtilUltAct { get; set; }

    public DateTime? DtUltAct { get; set; }

    public bool? Activo { get; set; }
}
