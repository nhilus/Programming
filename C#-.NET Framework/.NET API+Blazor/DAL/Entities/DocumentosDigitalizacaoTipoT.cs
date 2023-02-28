using System;
using System.Collections.Generic;

namespace DAL.Entities;

public partial class DocumentosDigitalizacaoTipoT
{
    public int Id { get; set; }

    public string Codigo { get; set; } = null!;

    public string Descricao { get; set; } = null!;

    public string? CatAdos { get; set; }

    public string? Report { get; set; }

    public int? IdEntidade { get; set; }
}
