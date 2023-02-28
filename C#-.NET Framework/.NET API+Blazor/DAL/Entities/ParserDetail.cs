using System;
using System.Collections.Generic;

namespace DAL.Entities;

public partial class ParserDetail
{
    public int Id { get; set; }

    public DateTime? CreationDate { get; set; }

    public int? IdHeader { get; set; }

    public string? CodDetalhe { get; set; }

    public int? NumVolume { get; set; }

    public string? TipoVolume { get; set; }

    public decimal? Peso { get; set; }

    public double? M3 { get; set; }

    public int? LineIndex { get; set; }

    public string? FileName { get; set; }

    public string? RefCli { get; set; }
}
