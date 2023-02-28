using System;
using System.Collections.Generic;

namespace GCOM2Users.Models;

public partial class ReclamacaoTipoCausaT
{
    public int Id { get; set; }

    public int IdTipo { get; set; }

    public int IdCausa { get; set; }
}
