using System;
using System.Collections.Generic;

namespace DAL.Entities;

public partial class ClienteEmailingTiposT
{
    public int Id { get; set; }

    public string Codigo { get; set; } = null!;

    public string Descricao { get; set; } = null!;

    public string Report { get; set; } = null!;

    public string Formato { get; set; } = null!;

    public string ParamsSample { get; set; } = null!;

    public string? Subject { get; set; }

    public string? Body { get; set; }

    public string? FilePrefix { get; set; }

    public int IdEntidade { get; set; }

    public bool Activo { get; set; }

    public string? EmailRemetente { get; set; }

    public bool SendEmpty { get; set; }

    public bool EnviaPortal { get; set; }

    public string? ParamQuebra { get; set; }

    public int? IdTipoEmailingDetalhe { get; set; }

    public bool? RegularProcessing { get; set; }

    public bool? PermMultiplasMoradas { get; set; }

    public bool? PermEnvioManual { get; set; }

    public bool? ProcessaJob { get; set; }

    public bool? IsVisivel { get; set; }
}
