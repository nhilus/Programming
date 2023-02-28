using System;
using System.Collections.Generic;

namespace DAL.Entities;

public partial class ReclamacaoTipoCausaT
{
    public int Id { get; set; }

    public int IdTipo { get; set; }

    public int IdCausa { get; set; }
}
