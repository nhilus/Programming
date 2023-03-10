using System;
using System.Collections.Generic;

namespace GCOM2Users.Models;

public partial class EntrevistaDocumento
{
    public int Id { get; set; }

    public int? IdEntrevista { get; set; }

    public string? Nome { get; set; }

    public string? Descricao { get; set; }

    public string? ServerLocation { get; set; }

    public int? Tamanho { get; set; }

    public string? MimeType { get; set; }

    public string? Guid { get; set; }

    public int? IdUtilIntrod { get; set; }

    public DateTime? DtIntrod { get; set; }
}
