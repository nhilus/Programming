using System;
using System.Collections.Generic;

namespace DAL.Entities;

public partial class ParserHeadersReferencia
{
    public int Id { get; set; }

    public DateTime? CreationDate { get; set; }

    public int? IdHeader { get; set; }

    public string? CodReferencia { get; set; }

    public string? Referencia { get; set; }

    public int? LineIndex { get; set; }
}
