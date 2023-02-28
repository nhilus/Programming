using System;
using System.Collections.Generic;

namespace GCOM2Users.Models;

public partial class ParserDetailsTemp
{
    public int Id { get; set; }

    public DateTime? CreationDate { get; set; }

    public int? IdHeader { get; set; }

    public string? CodDetalhe { get; set; }

    public int? NumVolume { get; set; }

    public string? TipoVolume { get; set; }

    public decimal? Peso { get; set; }

    public decimal? M3 { get; set; }
}
