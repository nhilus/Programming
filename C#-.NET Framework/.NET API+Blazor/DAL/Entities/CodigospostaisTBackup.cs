using System;
using System.Collections.Generic;

namespace DAL.Entities;

public partial class CodigospostaisTBackup
{
    public int Id { get; set; }

    public string? Cpostal { get; set; }

    public string Cp4 { get; set; } = null!;

    public string Cp3 { get; set; } = null!;

    public string Localidade { get; set; } = null!;

    public string? Cp7l { get; set; }

    public int IdPlataforma { get; set; }

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

    public int? IdDistrito { get; set; }

    public int? IdIvareg { get; set; }
}
