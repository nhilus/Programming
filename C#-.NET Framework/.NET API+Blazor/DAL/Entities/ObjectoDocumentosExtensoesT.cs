using System;
using System.Collections.Generic;

namespace DAL.Entities;

public partial class ObjectoDocumentosExtensoesT
{
    public int Id { get; set; }

    public string Extensao { get; set; } = null!;

    public string Imagem { get; set; } = null!;
}
