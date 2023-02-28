using System;
using System.Collections.Generic;

namespace DAL.Entities;

public partial class EntrevistaSugestaoCriteriosTipo
{
    public byte IdEntrevistaCriterio { get; set; }

    public byte IdEntidade { get; set; }

    public byte IdEntrevistaTipo { get; set; }
}
