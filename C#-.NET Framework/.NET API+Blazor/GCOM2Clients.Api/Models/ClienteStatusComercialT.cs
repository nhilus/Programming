using System;
using System.Collections.Generic;

namespace GCOM2Users.Models;

public partial class ClienteStatusComercialT
{
    public int Id { get; set; }

    public string Codigo { get; set; } = null!;

    public string Descricao { get; set; } = null!;

    public bool Captado { get; set; }

    public bool CaptadoOcasional { get; set; }

    public bool Negociacao { get; set; }

    public bool ValidoBp { get; set; }

    public bool SemPcred { get; set; }

    public int TempRespPcred { get; set; }

    public bool Default { get; set; }

    public int IdEntidade { get; set; }

    public bool Activo { get; set; }

    public string Cor { get; set; } = null!;

    public bool? InvalidoParaSalesLead { get; set; }
}
