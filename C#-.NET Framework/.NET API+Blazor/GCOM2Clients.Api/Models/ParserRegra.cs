using System;
using System.Collections.Generic;

namespace GCOM2Users.Models;

public partial class ParserRegra
{
    public int? IdClienteParserParametros { get; set; }

    public int? Regra { get; set; }

    public string? Campo { get; set; }

    public string? ValorInicio { get; set; }

    public string? ValorFim { get; set; }
}
