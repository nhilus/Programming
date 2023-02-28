using System;
using System.Collections.Generic;

namespace DAL.Entities;

public partial class TarifaTipoIncidenciaT
{
    public int Id { get; set; }

    public string Codigo { get; set; } = null!;

    public string Descricao { get; set; } = null!;

    public string Variavel { get; set; } = null!;

    public decimal UnidArredonda { get; set; }

    public string ValorRef { get; set; } = null!;

    public int? IdServicoDet { get; set; }

    public int IdEntidade { get; set; }

    public bool? Activo { get; set; }
}
