using System;
using System.Collections.Generic;

namespace DAL.Entities;

public partial class ClienteTlog
{
    public int IdTrigger { get; set; }

    public DateTime DtTrigger { get; set; }

    public int Id { get; set; }

    public string? Nome { get; set; }

    public int? IdPais { get; set; }

    public string? NrContrib { get; set; }

    public int? IdTipoEntidade { get; set; }

    public string? Observacoes { get; set; }

    public int? IdCae { get; set; }

    public DateTime? DtUltAct { get; set; }

    public int? IdUtilUltAct { get; set; }

    public bool? Anulado { get; set; }

    public bool? GrupoRangel { get; set; }

    public bool? IsParticular { get; set; }

    public bool? IsEditavel { get; set; }
}
