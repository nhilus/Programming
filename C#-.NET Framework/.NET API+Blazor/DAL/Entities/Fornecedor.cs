using System;
using System.Collections.Generic;

namespace DAL.Entities;

public partial class Fornecedor
{
    public int Id { get; set; }

    public int IdTipoFornecedor { get; set; }

    public bool? Activo { get; set; }

    public int? IdUtilIntrod { get; set; }

    public DateTime? DtIntrod { get; set; }

    public int? IdUtilUltAct { get; set; }

    public DateTime? DtUltAct { get; set; }

    public int IdTipoContactoDefault { get; set; }

    public string? CodParceiro { get; set; }
}
