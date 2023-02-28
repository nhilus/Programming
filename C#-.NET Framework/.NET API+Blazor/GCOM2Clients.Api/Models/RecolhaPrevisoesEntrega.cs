using System;
using System.Collections.Generic;

namespace GCOM2Users.Models;

public partial class RecolhaPrevisoesEntrega
{
    public int Id { get; set; }

    public int? IdPickup { get; set; }

    public int? IdRota { get; set; }

    public int? IdMotorista { get; set; }

    public DateTime? Data { get; set; }

    public TimeSpan? HoraInicio { get; set; }

    public TimeSpan? HoraFim { get; set; }

    public DateTime? DtIntrod { get; set; }

    public int? IdUtilIntrod { get; set; }
}
