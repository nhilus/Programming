using System;
using System.Collections.Generic;

namespace GCOM2Users.Models;

public partial class ObjectoDocumentosExtensoesT
{
    public int Id { get; set; }

    public string Extensao { get; set; } = null!;

    public string Imagem { get; set; } = null!;
}
