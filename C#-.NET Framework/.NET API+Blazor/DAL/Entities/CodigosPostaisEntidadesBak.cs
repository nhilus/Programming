using System;
using System.Collections.Generic;

namespace DAL.Entities;

public partial class CodigosPostaisEntidadesBak
{
    public int IdCpostal { get; set; }

    public int IdEntidade { get; set; }

    public int? IdPlataforma { get; set; }

    public DateTime? HoraLimite { get; set; }

    public DateTime? CutOff1 { get; set; }

    public DateTime? CutOff2 { get; set; }

    public bool? Conecta { get; set; }

    public int? DiaEntrega { get; set; }

    public int? DiasOb { get; set; }

    public int? DiasIb { get; set; }

    public DateTime? HoraEntrega { get; set; }

    public int? IdRota { get; set; }

    public int? IdPais { get; set; }

    public int? IdZonaPais { get; set; }

    public int? IdEquipaComercial { get; set; }

    public DateTime? DtCriacao { get; set; }

    public int? IdUtilCriacao { get; set; }

    public DateTime? DtUltAlt { get; set; }

    public int? IdUtilUltAlt { get; set; }

    public bool Activo { get; set; }

    public int? IdPlataformaCtrl { get; set; }

    public int? IdPlatZona { get; set; }

    public TimeSpan? CutOffEnt1 { get; set; }

    public TimeSpan? CutOffEnt2 { get; set; }

    public TimeSpan? HoraLimiteRec { get; set; }

    public TimeSpan? CutOffRec1 { get; set; }

    public TimeSpan? CutOffRec2 { get; set; }

    public string? CodZona { get; set; }
}
