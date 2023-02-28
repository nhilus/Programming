using System;
using System.Collections.Generic;

namespace DAL.Entities;

public partial class ParserDetailsAt
{
    public int Id { get; set; }

    public DateTime? CreationDate { get; set; }

    public int? IdHeader { get; set; }

    public string? Detalhe { get; set; }

    public int? LineIndex { get; set; }
}
