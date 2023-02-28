using System;
using System.Collections.Generic;

namespace GCOM2Users.Models;

public partial class ParserRegrasValore
{
    public int? IdClienteParserParametros { get; set; }

    public int? Regra { get; set; }

    public string? Campo { get; set; }

    public string? Valor { get; set; }
}
