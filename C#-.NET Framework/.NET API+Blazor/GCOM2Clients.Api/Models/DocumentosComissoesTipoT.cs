using System;
using System.Collections.Generic;

namespace GCOM2Users.Models;

public partial class DocumentosComissoesTipoT
{
    public int Id { get; set; }

    public string Codigo { get; set; } = null!;

    public string Descricao { get; set; } = null!;

    public int IdEntidade { get; set; }

    public bool? IsComissionavel { get; set; }

    public bool Default { get; set; }

    public bool? Activo { get; set; }

    public int? NumMesesSfact { get; set; }
}
