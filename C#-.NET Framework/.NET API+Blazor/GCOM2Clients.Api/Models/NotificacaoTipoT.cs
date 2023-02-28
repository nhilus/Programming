using System;
using System.Collections.Generic;

namespace GCOM2Users.Models;

public partial class NotificacaoTipoT
{
    public int Id { get; set; }

    public string Codigo { get; set; } = null!;

    public string Descricao { get; set; } = null!;

    public string Detalhe { get; set; } = null!;

    public string Grupo { get; set; } = null!;

    public string? Subject { get; set; }

    public string Message { get; set; } = null!;

    public string? EmailFrom { get; set; }

    public bool? Activo { get; set; }

    public string? SubjectRelatorio { get; set; }

    public string? MessageRelatorio { get; set; }

    public bool? Visivel { get; set; }

    public int IdTipoContexto { get; set; }

    public bool? VisivelB2c { get; set; }

    public int? OrdemB2c { get; set; }

    public TimeSpan? HoraInicio { get; set; }

    public TimeSpan? HoraFim { get; set; }

    public bool? UseTemplate { get; set; }

    public string? TemplateFile { get; set; }
}
