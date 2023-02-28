using System;
using System.Collections.Generic;

namespace DAL.Entities;

public partial class EmailDestinatario
{
    public int Id { get; set; }

    public int IdEmail { get; set; }

    public string Destinatario { get; set; } = null!;
}
