using System;
using System.Collections.Generic;

namespace GCOM2Users.Models;

public partial class MenuUrl2T
{
    public int Id { get; set; }

    public int IdMenu { get; set; }

    public string? DescCurta { get; set; }

    public string Descricao { get; set; } = null!;

    public int IdUrl { get; set; }

    public string Imagem { get; set; } = null!;

    public string Imagemactivo { get; set; } = null!;

    public bool? Default { get; set; }

    public byte Posicao { get; set; }

    public bool? Activo { get; set; }
}
