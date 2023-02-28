using System;
using System.Collections.Generic;

namespace DAL.Entities;

public partial class ReclamacaoCausaDetalhe
{
    public int Id { get; set; }

    public int IdReclamacaoCausa { get; set; }

    public string Descricao { get; set; } = null!;

    public int IdEntidade { get; set; }

    public bool? Activo { get; set; }
}
