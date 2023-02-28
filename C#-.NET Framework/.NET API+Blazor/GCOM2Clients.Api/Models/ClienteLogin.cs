using System;
using System.Collections.Generic;

namespace GCOM2Users.Models;

public partial class ClienteLogin
{
    public int Id { get; set; }

    public int IdCliente { get; set; }

    public string Login { get; set; } = null!;

    public string Password { get; set; } = null!;

    public DateTime? DtCriacao { get; set; }

    public int? IdUtilCriacao { get; set; }

    public short? Timeout { get; set; }
}
