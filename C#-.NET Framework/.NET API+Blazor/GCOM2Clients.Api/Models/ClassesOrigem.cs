using System;
using System.Collections.Generic;

namespace GCOM2Users.Models;

public partial class ClassesOrigem
{
    public int Id { get; set; }

    public string Nome { get; set; } = null!;

    public int? IdCliente { get; set; }

    public int? IdServico { get; set; }

    public int? IdRegime { get; set; }

    public int? IdUtilIntrod { get; set; }

    public DateTime? DtIntrod { get; set; }

    public int IdEntidade { get; set; }

    public int? IdCliMorada { get; set; }
}
