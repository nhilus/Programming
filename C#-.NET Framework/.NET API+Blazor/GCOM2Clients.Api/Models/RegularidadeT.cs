using System;
using System.Collections.Generic;

namespace GCOM2Users.Models;

public partial class RegularidadeT
{
    public int Id { get; set; }

    public string Descricao { get; set; } = null!;

    public int? Dias { get; set; }

    public bool? Activo { get; set; }

    public bool? Workdayonly { get; set; }
}
