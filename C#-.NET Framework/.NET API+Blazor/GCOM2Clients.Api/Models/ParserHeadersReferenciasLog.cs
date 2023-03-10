using System;
using System.Collections.Generic;

namespace GCOM2Users.Models;

public partial class ParserHeadersReferenciasLog
{
    public int Id { get; set; }

    public DateTime BckDate { get; set; }

    public int IdHeaderReferencia { get; set; }

    public DateTime? CreationDate { get; set; }

    public int? IdHeader { get; set; }

    public string? CodReferencia { get; set; }

    public string? Referencia { get; set; }

    public int? LineIndex { get; set; }
}
