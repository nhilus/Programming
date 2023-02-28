using System;
using System.Collections.Generic;

namespace DAL.Entities;

public partial class ConsolidadosTipoT
{
    public int Id { get; set; }

    public string? Codigo { get; set; }

    public string? Descricao { get; set; }

    public bool? Activo { get; set; }

    public DateTime? DtIntrod { get; set; }

    public int? IdUtilItrod { get; set; }
}
