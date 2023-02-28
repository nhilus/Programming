using System;
using System.Collections.Generic;

namespace GCOM2Users.Models;

public partial class MenuUrl1T
{
    public int Id { get; set; }

    public string? DescCurta { get; set; }

    public string Descricao { get; set; } = null!;

    public string Imagem { get; set; } = null!;

    public string? Imagemactivo { get; set; }

    public byte? Posicao { get; set; }

    public int? IdMenuUrl1parent { get; set; }

    public bool? Visivel { get; set; }

    public bool? Activo { get; set; }
}
