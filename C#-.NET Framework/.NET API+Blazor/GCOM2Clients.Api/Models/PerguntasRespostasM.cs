using System;
using System.Collections.Generic;

namespace GCOM2Users.Models;

public partial class PerguntasRespostasM
{
    public int Id { get; set; }

    public int IdPergunta { get; set; }

    public int IdResposta { get; set; }

    public bool? Activo { get; set; }
}
