using System;
using System.Collections.Generic;

namespace GCOM2Users.Models;

public partial class EmailDestinatario
{
    public int Id { get; set; }

    public int IdEmail { get; set; }

    public string Destinatario { get; set; } = null!;
}
