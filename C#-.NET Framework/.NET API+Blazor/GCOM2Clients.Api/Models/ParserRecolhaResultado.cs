using System;
using System.Collections.Generic;

namespace GCOM2Users.Models;

public partial class ParserRecolhaResultado
{
    public int Id { get; set; }

    public int? IdRecolhaHeader { get; set; }

    public int? IdPickup { get; set; }

    public bool? Erro { get; set; }

    public string? DescErro { get; set; }

    public string? FileName { get; set; }

    public DateTime? DtIntrod { get; set; }
}
