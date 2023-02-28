using System;
using System.Collections.Generic;

namespace DAL.Entities;

public partial class IvaT
{
    public int Id { get; set; }

    public string Codigo { get; set; } = null!;

    public string Descricao { get; set; } = null!;

    public int? IdTipoIva { get; set; }

    public decimal Taxa { get; set; }

    public DateTime DtInicio { get; set; }

    public DateTime? DtFim { get; set; }

    public int? IdIvareg { get; set; }

    public int? Activo { get; set; }
}
