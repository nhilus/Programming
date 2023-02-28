using System;
using System.Collections.Generic;

namespace GCOM2Users.Models;

public partial class ParserDetailsAtLog
{
    public int Id { get; set; }

    public DateTime BckDate { get; set; }

    public int IdDetailAt { get; set; }

    public DateTime? CreationDate { get; set; }

    public int? IdHeader { get; set; }

    public string? Detalhe { get; set; }

    public int? LineIndex { get; set; }
}
