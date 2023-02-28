using System;
using System.Collections.Generic;

namespace DAL.Entities;

public partial class ManifestoLocPagaEntidade
{
    public byte IdLocPaga { get; set; }

    public byte IdEntidade { get; set; }

    public string Descricao { get; set; } = null!;
}
