using System;
using System.Collections.Generic;

namespace GCOM2Users.Models;

public partial class ManifestoPrevisoesEntrega
{
    public int? IdManifesto { get; set; }

    public int? IdRota { get; set; }

    public int? IdMotorista { get; set; }

    public DateTime? Data { get; set; }

    public TimeSpan? HoraInicio { get; set; }

    public TimeSpan? HoraFim { get; set; }

    public DateTime? DtIntrod { get; set; }

    public int? IdUtilIntrod { get; set; }

    public int? IdPrevisoesEntrega { get; set; }

    public int Id { get; set; }
}
