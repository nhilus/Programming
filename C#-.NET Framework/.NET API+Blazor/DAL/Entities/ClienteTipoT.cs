using System;
using System.Collections.Generic;

namespace DAL.Entities;

public partial class ClienteTipoT
{
    public byte Id { get; set; }

    public string Codigo { get; set; } = null!;

    public string? Nome { get; set; }

    public string? Descricao { get; set; }

    public string? ImgTipo { get; set; }

    public byte IdEntidade { get; set; }
}
