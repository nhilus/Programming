using System;
using System.Collections.Generic;

namespace DAL.Entities;

public partial class ClienteCampanha
{
    public int Id { get; set; }

    public string Codigo { get; set; } = null!;

    public string Descricao { get; set; } = null!;

    public string? Obs { get; set; }

    public bool? Activo { get; set; }

    public DateTime? DtIntrod { get; set; }

    public int? IdUtilIntrod { get; set; }

    public int? IdEntidade { get; set; }

    public bool? TodosClientes { get; set; }

    public DateTime? DtInicio { get; set; }

    public DateTime? DtFim { get; set; }
}
