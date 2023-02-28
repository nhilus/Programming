using System;
using System.Collections.Generic;

namespace GCOM2Users.Models;

public partial class Cliente
{
    public int Id { get; set; }

    public string Nome { get; set; } = null!;

    public int IdPais { get; set; }

    public string? NrContrib { get; set; }

    public int IdTipoEntidade { get; set; }

    public string? Observacoes { get; set; }

    public int? IdCae { get; set; }

    public DateTime DtUltAct { get; set; }

    public int IdUtilUltAct { get; set; }

    public bool Anulado { get; set; }

    public bool GrupoRangel { get; set; }

    /// <summary>
    /// Bit que identifica o cliente particular
    /// </summary>
    public bool IsParticular { get; set; }

    public bool? IsEditavel { get; set; }

    public int? IdSectorActividade { get; set; }

    public string? Bicc { get; set; }

    public string? Passaporte { get; set; }
}
