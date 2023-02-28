using System;
using System.Collections.Generic;

namespace DAL.Entities;

public partial class ContenciosoDocumento
{
    public int Id { get; set; }

    public int IdContencioso { get; set; }

    public int IdDocumentoTipo { get; set; }

    public DateTime DtIntrod { get; set; }

    public int IdUtilIntrod { get; set; }

    public string? Descricao { get; set; }

    public string Url { get; set; } = null!;

    public bool Eliminado { get; set; }

    public DateTime? DtElim { get; set; }

    public int? IdUtilElim { get; set; }
}
