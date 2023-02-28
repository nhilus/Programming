using System;
using System.Collections.Generic;

namespace GCOM2Users.Models;

public partial class RotaUtilizadoresLog
{
    public int Id { get; set; }

    public int IdRota { get; set; }

    public DateTime Data { get; set; }

    public short? IdUtilizador { get; set; }

    public bool Activo { get; set; }

    public DateTime DtIntrod { get; set; }

    public short IdUtilIntrod { get; set; }
}
