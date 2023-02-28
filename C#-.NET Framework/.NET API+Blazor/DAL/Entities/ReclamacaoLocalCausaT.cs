using System;
using System.Collections.Generic;

namespace DAL.Entities;

public partial class ReclamacaoLocalCausaT
{
    public int Id { get; set; }

    public int IdLocal { get; set; }

    public int IdCausa { get; set; }
}
