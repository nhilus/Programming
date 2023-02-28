using System;
using System.Collections.Generic;

namespace DAL.Entities;

public partial class ManifestoEstadosT
{
    public int Id { get; set; }

    public int IdEntidade { get; set; }

    public string? Codigo { get; set; }

    public string? Descricao { get; set; }

    public string? BackgroundColor { get; set; }

    public string? Icon { get; set; }

    public string? CodEstado { get; set; }
}
