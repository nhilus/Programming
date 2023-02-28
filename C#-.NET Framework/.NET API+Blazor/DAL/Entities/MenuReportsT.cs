using System;
using System.Collections.Generic;

namespace DAL.Entities;

public partial class MenuReportsT
{
    public int Id { get; set; }

    public int IdTipoReport { get; set; }

    public string Url { get; set; } = null!;

    public string Tema { get; set; } = null!;

    public string Descricao { get; set; } = null!;

    public string? Detalhe { get; set; }

    public string? Dados { get; set; }

    public string? Parametros { get; set; }

    public byte? Separadores { get; set; }

    public bool? Visivel { get; set; }

    public bool? Activo { get; set; }

    public bool AllowNoLogin { get; set; }
}
