using System;
using System.Collections.Generic;

namespace GCOM2Users.Models;

public partial class ParserErrosInesperado
{
    public int Id { get; set; }

    public int? IdCliParserParam { get; set; }

    public string? Error { get; set; }

    public DateTime? DtIntrod { get; set; }
}
